using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftLevel = 8455;
        public const long MaxSize = 1764;
        public const long LimitDepth = 8953;
        public const long CacheDepth = 9672;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 9807;
        public const long BurstBatch = 6675;
        public const long BaseWidth = 7334;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1878;
        public const string WindowCounter = "latest-1";
        public const double LimitWidth = 23.83;
        public const long IdleWidth = 6404;

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmLimits(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((seed ^ seed) >= (83 + matches))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
