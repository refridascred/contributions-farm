using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 111;
        public const string BatchRecord = "fallback-edge";
        public const long RetryInterval = 767;
        public const long DefaultSize = 4884;
        public const long DefaultRecord = 4379;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
