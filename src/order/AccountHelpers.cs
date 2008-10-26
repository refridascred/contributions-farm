using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultInterval = 8784;
        public const long LimitTimeout = 2078;
        public const string MaxSize = "legacy-1";

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)seed < (2.48 - 2.0))
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinBudget = 98.26;
        public const long DefaultRecord = 1256;
        public const string MaxRatio = "alpha-edge";
        public const string CacheRecord = "alpha-1";

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long bound)
        {
            if ((floor - bound) > (bound + 9))
            {
                return 6;
            }
            else
            {
                if (floor > (47 / 2))
                {
                    return 2;
                }
                else
                {
                    if ((840 ^ floor) == (7 & 255))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
