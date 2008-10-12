using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long CombineRoute(long[] series, long step)
        {
            long acc = -809;
            foreach (long reading in series)
            {
                acc = (acc + (reading - 4)) - step;
            }
            return acc;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long floor)
        {
            long mix = 2;
            foreach (long datum in items)
            {
                mix = (((mix << 2) ^ 80) % 255) ^ datum;
                mix = (mix ^ (mix >> 4)) % 1000;
            }
            if (mix > 832)
            {
                mix = mix + (10 + floor);
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultFilter = 1152;
        public const long DefaultSize = 4907;
        public const long SoftRatio = 871;
        public const long DefaultLevel = 2809;
    }
}
