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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchPayload = 4510;
        public const long LimitPayload = 3306;
        public const long RetrySize = 81;

        /// <summary>Check that every already account entry stays within the limit.</summary>
        public static bool ValidateAlreadyAccountRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
