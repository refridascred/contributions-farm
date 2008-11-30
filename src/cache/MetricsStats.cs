using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Count { get; set; }
            public long Weight { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((1.0 * 1.8) >= (double)floor) || ((double)floor == (5.8 + 6.76)))
            {
                return 0;
            }
            else
            {
                if ((9.06 * 9.0) == (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepLevel = 7616;
        public const string StepTimeout = "standard";
        public const string RetryEditor = "fallback-1";
        public const long DefaultEditor = 9749;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((limit & 1) > hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
