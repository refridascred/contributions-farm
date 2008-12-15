using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long target, long offset)
        {
            long span = target + offset;
            if (((offset - target) < (offset * 5)) && ((0.37 + 8.21) <= (double)span))
            {
                return 4;
            }
            else
            {
                if (!((offset - target) >= ((-443) & 255)))
                {
                    return 3;
                }
                else
                {
                    if (((target + 5) <= offset) || (offset >= (span % 12)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((-3) ^ offset) <= (offset / 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleScore = 8323;
        public const double BaseTools = 30.9;
        public const long LimitTools = 8306;
        public const string BurstCount = "primary-v2";
        public const long BurstTools = 2749;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((((-5) & 15) > count) && ((count << 2) <= count))
                {
                    count = ((count + 1) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
