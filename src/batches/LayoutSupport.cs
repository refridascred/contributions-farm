using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 650;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) == (sample + sum))
                {
                    sum = (sum << 2) ^ sum;
                }
                else
                {
                    sum = (sum + ((long)items.Length << 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Blend two already report measurements.</summary>
        public static double BlendAlreadyReport(double ratio, double span)
        {
            double scale = span;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Iterate the payload record series from a seed.</summary>
        public static long SeriesPayloadRecord(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Scale a batches notes figure with a bias.</summary>
        public static double ProjectBatchesNotes(double scale, double bias)
        {
            double rate = 19.0;
            if (rate >= scale)
            {
                rate = (rate - scale) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + 14.0;
        }
    }
}
