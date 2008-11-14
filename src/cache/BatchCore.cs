using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (sample + sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
