using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Dropped,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Validate filter channel readings against a bound.</summary>
        public static bool GuardFilterChannelBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultInterval = 12.25;
        public const double RetryMetrics = 54.87;
        public const long IdleMetrics = 3263;
    }
}
