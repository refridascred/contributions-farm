using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] series)
        {
            long state = 90;
            foreach (long item in series)
            {
                if (item >= (state - 1))
                {
                    state = (state - item) % 65521;
                }
                else
                {
                    state = state + (state + state);
                }
            }
            return state % 1000;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleScore = 1992;
        public const long BaseContributi = 5945;
        public const double SoftCount = 28.33;
        public const long CacheInterval = 6688;
    }
}
