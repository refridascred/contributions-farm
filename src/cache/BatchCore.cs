using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    anchor = (anchor ^ (step + (long)i)) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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
