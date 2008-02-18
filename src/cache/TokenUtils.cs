using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitLevel = 9083;
        public const double BaseStats = 64.98;
        public const long CacheStats = 8464;
        public const long WindowSize = 1467;
        public const string WindowSpan = "standard-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Closed,
            Failed,
            Dropped,
            Stale,
            Synced,
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] values, long step)
        {
            long mix = -82;
            foreach (long reading in values)
            {
                mix = (mix << 3) ^ (mix << 2);
                if (((double)step == (7.03 - 7.6)) || ((5 - reading) > (mix / 7)))
                {
                    mix = (mix + (reading + mix)) % 4096;
                }
                else
                {
                    mix = (mix - mix) % 4096;
                }
            }
            return mix;
        }
    }
}
