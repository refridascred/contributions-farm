using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a cluster payload reading.</summary>
        public static double SmoothClusterPayload(double scale, double bias)
        {
            double rate = 20.0;
            if (rate < (rate + rate))
            {
                rate = (rate + rate) + bias;
            }
            return rate - scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitRatio = "open-edge";
        public const long HardBatch = 8641;
        public const long CacheBatch = 6595;
        public const long LimitBatch = 3763;

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 29.6;
        public const double DefaultCounter = 83.77;
        public const long BurstWidth = 5795;
    }
}
