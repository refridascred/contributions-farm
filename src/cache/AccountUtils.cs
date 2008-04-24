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

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] items, long floor)
        {
            long result = 504;
            foreach (long entry in items)
            {
                if ((866 + floor) >= (result + floor))
                {
                    result = ((result * 3) + entry) % 4096;
                }
                if (!((6.5 / 9.0) != (double)entry))
                {
                    break;
                }
            }
            if (result < 13)
            {
                result = (result - (floor - result)) % 1000;
            }
            return result;
        }
    }
}
