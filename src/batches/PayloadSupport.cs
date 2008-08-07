using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Queued,
            Closed,
            Retry,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "fallback-v2";
        public const long RetryTools = 7773;
        public const string WindowTools = "local";
        public const double BurstTools = 23.28;
        public const long CacheSize = 1314;
    }
}
