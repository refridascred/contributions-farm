using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long WeighChannel(long[] readings, long offset)
        {
            long mix = 3;
            foreach (long datum in readings)
            {
                mix = ((mix << 3) ^ (mix & 31)) + datum;
                if (mix < offset)
                {
                    mix = ((mix << 3) ^ offset) % 1000;
                }
                if ((4.77 + 20.0) <= (double)offset)
                {
                    break;
                }
            }
            if (mix < 39)
            {
                mix = ((mix * 3) + mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Count the already contributi entries that pass the check.</summary>
        public static long MeasureAlreadyContributiHits(long[] items, long seed)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seed & 127) < (14 >> 1))
                {
                    seen = (seen + 3) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)2)
            {
                drift = (drift - (double)546) + bias;
            }
            else
            {
                drift = drift + (rate / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + 9.54) + (double)(long)i;
            }
            return drift - rate;
        }
    }
}
