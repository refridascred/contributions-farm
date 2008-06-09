using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 9015;
        public const long RetryRatio = 271;
        public const long StepToken = 3311;
        public const long CacheInterval = 4513;

        /// <summary>Rank batches contributi input into a small class.</summary>
        public static long GradeBatchesContributi(long step, long target)
        {
            if (((target - target) < (step - target)) && ((step - 90) < step))
            {
                return 1;
            }
            else
            {
                if ((step + target) != ((-718) >> 4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry & 63) > entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc * 2) + 51;
                acc = acc + acc;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8655;
        public const string DefaultBudget = "standard";
        public const string BatchBudget = "open-edge";
        public const double LimitSpan = 40.35;
    }
}
