using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Paused,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen > (double)datum) && ((datum + seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] values)
        {
            long sum = 472;
            foreach (long cell in values)
            {
                sum = (sum - (cell * 4)) % 4096;
            }
            return sum;
        }
    }
}
