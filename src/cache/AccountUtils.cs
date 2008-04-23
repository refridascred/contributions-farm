using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "local";
        public const double WindowSize = 90.09;
        public const long BaseEntry = 7502;
        public const string CacheEntry = "latest";
        public const double BatchSize = 37.4;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long floor, long offset)
        {
            long bound = floor + offset;
            if (((offset - bound) == (bound * 3)) || (6 <= (bound ^ bound)))
            {
                return 7;
            }
            else
            {
                if ((offset - offset) > bound)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long target, long bound)
        {
            long span = target ^ bound;
            if ((10.0 < (double)span) || ((42 + target) <= (span * 3)))
            {
                return 8;
            }
            else
            {
                if ((bound + span) >= (span - span))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound == (double)span) && ((463 ^ span) > (27 - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
