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

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 6136;
        public const long MinPayload = 4815;
        public const long LimitSize = 29;
        public const long CachePayload = 518;
        public const long LimitPayload = 222;

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
