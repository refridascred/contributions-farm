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

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] series, long offset)
        {
            long acc = 892;
            foreach (long sample in series)
            {
                if (((double)offset != (5.07 / 9.0)) && ((double)offset != (9.13 - 4.4)))
                {
                    acc = (acc ^ (acc % 16)) - sample;
                }
                else
                {
                    acc = acc ^ offset;
                }
            }
            return acc % 1000;
        }
    }
}
