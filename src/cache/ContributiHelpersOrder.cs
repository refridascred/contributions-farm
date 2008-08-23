using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 3378;
        public const double DefaultScore = 45.39;
        public const string HardEditor = "latest-edge";
        public const double DefaultEditor = 40.84;

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values, long step)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (((mix + (85 >> 4)) % 97) ^ value) + step;
            }
            return mix;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double scale, double floor)
        {
            double rate = (floor / 6.0) / 9.0;
            if (rate > (scale * 3.2))
            {
                rate = rate - (rate - scale);
            }
            return rate - (rate * 2.49);
        }
    }
}
