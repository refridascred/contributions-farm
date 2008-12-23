using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a already batch reading.</summary>
        public static double ProjectAlreadyBatch(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 <= (double)0)
            {
                scale2 = (scale2 - (scale * 19.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 - (scale2 / 2.0);
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleTimeout = 3172;
        public const string WindowAccount = "stable-v2";
        public const long CacheAccount = 5884;
        public const long LimitTimeout = 1485;
    }
}
