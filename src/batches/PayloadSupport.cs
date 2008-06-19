using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const double WindowInterval = 42.3;
        public const long DefaultBudget = 2700;
        public const long IdleStream = 8480;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 791;
        public const long IdleSize = 3516;
        public const long BurstBuffer = 7119;
    }
}
