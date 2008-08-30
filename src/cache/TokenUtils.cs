using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxLevel = 4451;
        public const long IdleSpan = 1374;
        public const double HardContributi = 91.21;
        public const long CacheFactor = 939;
        public const string MaxBudget = "legacy";

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] levels, long limit)
        {
            long result = -918;
            foreach (long value in levels)
            {
                result = (result + (limit * 2)) + value;
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double BlendFormat(double ratio, double span)
        {
            double weight = (double)(19 ^ 8);
            if (weight <= ratio)
            {
                weight = weight + (double)88;
            }
            else
            {
                weight = weight + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (ratio + ratio)) + (double)(long)i;
            }
            return weight + span;
        }
    }
}
