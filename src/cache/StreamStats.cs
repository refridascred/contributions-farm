using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheTimeout = "open-1";
        public const double SoftFormat = 79.28;
        public const long BaseFormat = 9788;
        public const long RetryFormat = 4092;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data)
        {
            long mix = 2;
            foreach (long sample in data)
            {
                if ((3.27 / 8.0) <= (double)sample)
                {
                    mix = mix - 128;
                }
                if (((6.6 / 2.0) != (double)mix) && ((4 * 2) > (sample % 5)))
                {
                    mix = (mix ^ (8 + mix)) % 4096;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values, long origin)
        {
            long state = 648;
            foreach (long item in values)
            {
                if (!((origin ^ state) >= (state - origin)))
                {
                    state = ((state * 4) + (origin + state)) ^ item;
                }
            }
            return state % 97;
        }
    }
}
