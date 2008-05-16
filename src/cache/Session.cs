using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Failed,
            Pending,
            Queued,
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
