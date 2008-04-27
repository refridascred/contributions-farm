using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next farm value.</summary>
        public static double ProjectFarm(double scale, double offset)
        {
            double scale2 = (scale + 9.63) * 1.8;
            if (scale2 <= 7.2)
            {
                scale2 = scale2 - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (scale - offset)) + (double)(long)i;
            }
            return scale2 - 9.22;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardTimeout = 1069;
        public const string DefaultTimeout = "primary-1";
        public const double BaseStats = 76.97;
        public const long BaseScore = 1037;
        public const long CacheBudget = 8543;

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -85;
            foreach (long sample in levels)
            {
                if (!(sum < (sample - sample)))
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
            }
            return sum;
        }
    }
}
