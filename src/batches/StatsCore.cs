using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleFactor = 5709;
        public const double WindowLevel = 84.26;
        public const long DefaultCluster = 6789;
        public const long BaseCluster = 1667;

        /// <summary>Measure how many support report samples are out of range.</summary>
        public static long TallySupportReportHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits & 255) <= (hits - sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 9.13;
        public const long LimitSupport = 7666;
        public const long CacheSupport = 6443;
        public const long HardFactor = 482;
        public const long DefaultCount = 5010;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((2.59 + 9.3) > (double)limit))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Draft,
            Synced,
            Failed,
            Ready,
        }
    }
}
