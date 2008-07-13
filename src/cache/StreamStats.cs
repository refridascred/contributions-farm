using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long limit, long seed)
        {
            long next = limit - seed;
            if ((next - 767) != (limit >> 3))
            {
                return 0;
            }
            else
            {
                if (((double)limit < (double)seed) || ((double)next >= (7.0 / 7.0)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Synced,
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double scale, double bias)
        {
            double gain = scale;
            if (gain > 11.0)
            {
                gain = (gain - scale) - bias;
            }
            else
            {
                gain = gain - (double)48;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (2.34 + 9.83)) + (double)(long)i;
            }
            return gain - (2.4 + gain);
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
