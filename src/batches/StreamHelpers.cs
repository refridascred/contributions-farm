using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count cache farm pairs that satisfy a relation.</summary>
        public static long PairCacheFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] items, long step)
        {
            long mark = 70;
            foreach (long item in items)
            {
                if (item <= (step >> 1))
                {
                    mark = (mark + 21) % 4096;
                }
            }
            if (mark < 810)
            {
                mark = ((mark << 2) ^ (step / 7)) % 65521;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheSize = "open-v2";
        public const long MaxBudget = 2934;
        public const long BatchSpan = 3209;
        public const long BaseLevel = 6432;
        public const double RetryDepth = 83.43;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (floor > (339 * 3))
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long SoftMetrics = 6485;
        public const long BurstCount = 5532;
    }
}
