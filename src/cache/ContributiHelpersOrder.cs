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

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin << 2) != ((long)i - anchor))
                {
                    anchor = (anchor * 4) + ((long)i & 3);
                    anchor = ((anchor << 2) ^ origin) % 1000;
                }
                for (int i2 = 0; i2 < 11; i2++)
                {
                    anchor = (((anchor * 5) + anchor) % 1000) ^ (long)i2;
                    anchor = (anchor * 2) + (origin ^ origin);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
