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

        /// <summary>Audit metric channel readings against a rule.</summary>
        public static long AuditMetricChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) > (count + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultTimeout = 4911;
        public const long HardSchema = 8053;
        public const string StepSchema = "cached-1";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
