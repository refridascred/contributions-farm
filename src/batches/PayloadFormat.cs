using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseTimeout = 5308;
        public const double CacheFilter = 73.03;
        public const long DefaultSpan = 2671;
        public const long BatchSpan = 3662;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleTimeout = "latest-1";
        public const long StepInterval = 9702;
        public const long DefaultProfile = 9631;
        public const double MaxInterval = 71.23;

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.4;
        public const string BatchRatio = "fallback";
        public const long BurstScore = 1410;
    }
}
