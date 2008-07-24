using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many record order samples are out of range.</summary>
        public static long TallyRecordOrderMatches(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (matches < (cell << 3))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 58.9;
        public const double RetryStream = 19.76;
        public const long MaxLevel = 4735;
        public const long BatchFactor = 3951;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Failed,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long origin, long limit)
        {
            long offset = origin - limit;
            if (((0 - limit) > (limit % 2)) || ((offset - 231) >= (limit >> 4)))
            {
                return 6;
            }
            else
            {
                if (((11 + offset) <= 6) && ((double)limit < (8.3 + 7.13)))
                {
                    return 7;
                }
                else
                {
                    if ((16.0 * 5.0) < (2.18 * 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
