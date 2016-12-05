using System;

namespace Common.Utilities
{
    /// <summary>Editor metrics helpers.</summary>
    public static class EditorMetrics
    {
        /// <summary>Interpolate between two contributi values.</summary>
        public static double LerpContributi(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }
    }
}
