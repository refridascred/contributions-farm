using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 66.56;
        public const double WindowQueue = 84.84;
        public const long BurstQueue = 3933;
        public const string BaseQueue = "staging-1";
        public const long MaxSpan = 5149;

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double scale = (double)0 - ratio;
            return scale + offset;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3911;
        public const double WindowFactor = 88.06;
        public const long MaxBatches = 6609;
        public const double StepBatches = 97.73;
        public const long LimitBudget = 269;

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] series)
        {
            long result = 8;
            foreach (long sample in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    result = ((result * 4) + ((long)i & 1)) + sample;
                }
                result = result - (result / 6);
            }
            return result;
        }
    }
}
