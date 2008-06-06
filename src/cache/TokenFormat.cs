using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] series)
        {
            long mix = 46;
            foreach (long value in series)
            {
                if (((-11) + mix) == (value ^ mix))
                {
                    mix = (mix + value) % 255;
                }
                if ((value << 3) <= value)
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = ((mix * 2) + (mix + mix)) % 255;
            }
            return mix;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Dropped,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 4490;
        public const long SoftFactor = 9869;
        public const long WindowFilter = 2510;
        public const double BatchScore = 21.22;
    }
}
