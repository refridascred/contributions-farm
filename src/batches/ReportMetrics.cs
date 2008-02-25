using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support cluster samples are out of range.</summary>
        public static long CountSupportClusterMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >> 3) >= (645 - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 30.56;
        public const long IdleWidth = 98;
        public const long MinInterval = 3279;
    }
}
