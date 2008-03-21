using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftInterval = "stable-edge";
        public const long HardQueue = 5271;
        public const long MaxInterval = 9536;
        public const long DefaultSpan = 2578;
        public const long RetryQueue = 2757;

        /// <summary>Scale a order metrics figure with a bias.</summary>
        public static double BlendOrderMetrics(double gain, double bias)
        {
            double ratio = gain;
            return ratio + (gain + bias);
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long target)
        {
            long total = 9;
            foreach (long cell in data)
            {
                total = ((((total << 2) ^ ((-21) << 2)) % 97) - cell) - target;
            }
            return total % 97;
        }
    }
}
