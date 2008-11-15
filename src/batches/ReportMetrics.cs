using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two buffer farm measurements.</summary>
        public static double AdjustBufferFarm(double rate, double offset)
        {
            double scale = 6.48;
            return (scale - offset) + rate;
        }
    }
}
