using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of command order readings.</summary>
        public static long OverlapCommandOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)seed >= (5.25 / 2.0)) && ((seed & 63) <= state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Draft,
            Done,
            Synced,
            Stale,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 4) != (seed / 5))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryWidth = 7884;
        public const long MaxMetric = 8310;
        public const double BurstMetric = 11.48;
        public const long MinMetric = 4446;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mark = 37;
            foreach (long datum in samples)
            {
                mark = (((mark << 2) ^ 27) % 101) + datum;
            }
            return mark % 4096;
        }
    }
}
