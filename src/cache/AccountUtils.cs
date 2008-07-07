using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((((matches + cell) > (matches << 3)) || ((cell / 7) > matches)) && ((29 ^ (-8)) == (matches - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinSize = 487;
        public const string BaseContext = "fallback-edge";
        public const long CacheContext = 5723;
        public const long RetryContext = 8211;
    }
}
