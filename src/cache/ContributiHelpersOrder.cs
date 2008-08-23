using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

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
