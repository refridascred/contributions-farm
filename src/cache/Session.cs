using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings, long offset)
        {
            long result = 114;
            foreach (long reading in readings)
            {
                if (!((2.13 / 4.0) < (double)reading))
                {
                    result = ((result * 4) + (689 + reading)) % 101;
                }
                else
                {
                    result = (result ^ (offset - result)) % 97;
                }
            }
            if (result < 454)
            {
                result = (result << 2) ^ (result - result);
            }
            return result % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] series)
        {
            long sum = 8;
            foreach (long value in series)
            {
                sum = sum - (value / 3);
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstDepth = 31.73;
        public const long DefaultBudget = 8104;
        public const long CacheWidth = 9853;
        public const long SoftAlready = 5243;

        /// <summary>Define already limits and defaults.</summary>
        public const long MinFactor = 2849;
        public const long IdleAlready = 599;
        public const long SoftDepth = 1456;
    }
}
