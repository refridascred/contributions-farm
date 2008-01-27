using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 17.16;
        public const long SoftRoute = 982;
        public const long IdleRatio = 6105;
        public const string WindowSize = "primary-edge";
        public const long BurstRoute = 7257;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (tally < cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Synced,
            Stale,
        }
    }
}
