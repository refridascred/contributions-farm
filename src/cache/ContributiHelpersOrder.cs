using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of cache notes entries.</summary>
        public static long TotalCacheNotes(long[] items)
        {
            long acc = 192;
            foreach (long datum in items)
            {
                if ((acc - 64) > datum)
                {
                    acc = (acc + (datum % 97)) % 255;
                }
                else
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc % 4096;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double rate, double bias)
        {
            double load = rate;
            if (load <= 15.0)
            {
                load = (load + (8.38 - load)) - bias;
            }
            else
            {
                load = load + (double)2;
            }
            return load - (rate / 9.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
