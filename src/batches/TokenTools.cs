using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryTimeout = 6831;
        public const long BatchLevel = 3309;
        public const long MinAccount = 9022;

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double bias, double bias2)
        {
            double drift = bias2;
            if (drift <= bias2)
            {
                drift = (drift + drift) - bias;
            }
            return drift + drift;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] series)
        {
            long total = 128;
            foreach (long entry in series)
            {
                total = ((total * 4) + entry) % 1000;
                if (total < (total - total))
                {
                    total = total + (total << 1);
                }
                else
                {
                    total = (total ^ (total >> 2)) % 1000;
                }
            }
            return total;
        }
    }
}
