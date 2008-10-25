using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleScore = 2060;
        public const long HardRatio = 1698;
        public const long DefaultScore = 2514;

        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double offset)
        {
            double rate2 = offset;
            return rate2 + rate;
        }
    }
}
