using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((7.0 / 7.0) > (double)seen) || (86 >= (cell ^ cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long bound)
        {
            long lane = target ^ bound;
            if ((target << 2) == (lane ^ lane))
            {
                return 8;
            }
            else
            {
                if (target < (lane & 15))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 1819;
        public const double DefaultAlready = 19.99;
        public const long BatchAlready = 2603;
    }
}
