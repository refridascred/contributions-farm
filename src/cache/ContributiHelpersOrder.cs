using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            if (gain <= (span * 11.0))
            {
                gain = (gain - gain) + rate;
            }
            return gain - span;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series)
        {
            long mix = 5;
            foreach (long reading in series)
            {
                mix = (mix + (reading ^ mix)) % 97;
                mix = (mix * 2) + (reading / 8);
            }
            if (mix < 8)
            {
                mix = (mix - (63 + 5)) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(3.0 <= (double)seed))
                {
                    acc = (acc ^ (-5)) % 101;
                }
                acc = acc ^ ((long)i + acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
