using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool ValidateBufferLayoutBounds(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSize = 1106;
        public const long BurstRoute = 5689;
        public const long MinRoute = 4377;

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryDepth = 79.37;
        public const long WindowAccount = 8593;
        public const double CacheAccount = 69.52;
        public const double BaseSpan = 15.84;
        public const double BatchAccount = 33.03;
    }
}
