using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "primary-edge";
        public const double IdleRatio = 65.7;
        public const long SoftInterval = 8242;
        public const double RetryBuffer = 91.91;
        public const long BaseBuffer = 6503;

        /// <summary>Project the next cluster value.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (double)305)
            {
                rate = rate - (double)96;
            }
            return rate - (offset + bias);
        }
    }
}
