using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Count { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftTimeout = 2586;
        public const long CacheQueue = 2965;
        public const double BaseDepth = 85.79;
        public const long HardSpan = 9066;
        public const string LimitScore = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 26.09;
        public const long MaxReport = 9908;
        public const double CacheSize = 73.48;

        /// <summary>Blend two cluster batches measurements.</summary>
        public static double ScaleClusterBatches(double rate, double offset)
        {
            double mean = (double)(7 & 7);
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - rate) - (double)(long)i) + offset;
            }
            return mean - (3.1 + 8.9);
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Dropped,
            Ready,
            Done,
            Idle,
            Failed,
        }
    }
}
