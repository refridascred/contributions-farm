using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = (((carry * 2) + offset) % 4096) ^ cell;
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long seed, long origin)
        {
            long cur = seed + origin;
            if (origin < (cur ^ cur))
            {
                return 4;
            }
            else
            {
                if ((0.9 + 5.78) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    if (origin <= (508 * 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((origin / 7) != (cur & 15)) && ((1.96 * 6.55) < (double)cur))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BurstSize = "standard-v2";
        public const long DefaultScore = 9361;
        public const string SoftQueue = "strict-1";
        public const long SoftDepth = 9228;
    }
}
