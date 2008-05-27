using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double weight, double floor)
        {
            double scale = weight;
            return (scale + (double)0) + floor;
        }

        /// <summary>Fold a list of farm metrics readings.</summary>
        public static long TallyFarmMetrics(long[] data, long seed)
        {
            long result = 398;
            foreach (long entry in data)
            {
                result = (((result << 2) ^ (result * 3)) - entry) - seed;
            }
            if (result < 37)
            {
                result = (result + (result / 3)) % 65521;
            }
            return result;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 30.92;
        public const long CacheBuffer = 9610;
        public const string BurstCount = "staging";
        public const long MinBuffer = 7839;
        public const double BurstBuffer = 3.3;
    }
}
