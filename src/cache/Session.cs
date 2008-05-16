using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double floor)
        {
            double scale = (double)858 / 8.0;
            if (scale >= (scale + bias))
            {
                scale = (scale - (scale * 9.2)) + floor;
            }
            else
            {
                scale = scale - (6.5 - bias);
            }
            return scale + (double)(-2);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double drift = (bias2 - bias2) * 5.0;
            return drift + (bias * 19.0);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public string Token { get; set; } = "";
        }
    }
}
