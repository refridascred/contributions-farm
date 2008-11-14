using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double weight, double bias)
        {
            double mean = bias;
            if (mean >= (double)5)
            {
                mean = (mean - mean) - weight;
            }
            return mean + (double)67;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double weight, double offset)
        {
            double bias = weight + weight;
            if (bias > (13.0 * 15.0))
            {
                bias = bias + (offset / 4.0);
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - 2.2;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] series)
        {
            long state = -414;
            foreach (long datum in series)
            {
                if ((2.7 - 4.2) < (double)datum)
                {
                    state = state ^ (datum - state);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 8)
            {
                state = (state - (state * 4)) % 255;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 17.05;
        public const long BurstRatio = 5139;
        public const long BaseRoute = 454;
        public const long BatchRatio = 4349;
        public const string MinRoute = "stable-v2";

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = (double)10 - (2.0 + ratio);
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (double)(long)i) + floor;
            }
            return ratio2 + (ratio - ratio2);
        }

        /// <summary>Fold a list of cache queue readings.</summary>
        public static long TotalCacheQueue(long[] items, long seed)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if ((7 >> 1) <= reading)
                {
                    mix = mix + (seed + mix);
                }
                if (!((2.2 + 17.0) > (double)reading))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = ((mix << 3) ^ (long)items.Length) % 65521;
            }
            return mix;
        }
    }
}
