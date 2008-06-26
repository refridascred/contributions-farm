using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double gain = floor;
            return gain - (floor + weight);
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] data, long seed)
        {
            long result = 69;
            foreach (long reading in data)
            {
                if ((-670) > (reading << 2))
                {
                    result = ((result * 2) + (result - 6)) - seed;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long MaxSchema = 5966;
        public const long RetryTimeout = 4465;
        public const string MinSchema = "open-1";
    }
}
