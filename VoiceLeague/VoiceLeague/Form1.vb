Public Class OtionsForm
    Private Sub OtionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DefaultLookAndFeel1.EnableBonusSkins = True
        DefaultLookAndFeel1.LookAndFeel.SetSkinStyle("UseDefault;Skin: Darkroom")
    End Sub

    Private Sub OtionsForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DefaultLookAndFeel1.LookAndFeel.ActiveLookAndFeel.SetSkinStyle("Darkroom")
    End Sub
End Class
