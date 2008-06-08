using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double bias, double bias2)
        {
            double rate = (double)63 / 8.0;
            return (rate - bias) + bias2;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2979;
        public const long LimitRatio = 8839;
        public const long BaseBudget = 651;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheLevel = 3632;
        public const long WindowSchema = 4212;
        public const long StepRatio = 7226;
        public const double HardWidth = 55.85;
        public const long MinSchema = 1617;

        /// <summary>Fold a list of format entry readings.</summary>
        public static long TotalFormatEntry(long[] levels, long origin)
        {
            long carry = 17;
            foreach (long entry in levels)
            {
                if ((4.4 / 2.0) == (double)carry)
                {
                    carry = (((carry ^ carry) % 101) - entry) - origin;
                }
            }
            return carry;
        }
    }
}
