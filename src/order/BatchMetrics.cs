using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 6069;
        public const string LimitAccount = "open-edge";
        public const long BurstAccount = 526;
        public const long HardLevel = 6161;
        public const string MaxAccount = "staging-edge";

        /// <summary>Measure how many metric cache samples are out of range.</summary>
        public static long CountMetricCacheGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell * 4) == (matches * 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long anchor = target;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                anchor = anchor ^ anchor;
                anchor = (anchor - limit) % 97;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
