using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double scale, double floor)
        {
            double rate = (double)(451 >> 4);
            if (rate < (7.0 - 6.95))
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - scale) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long target, long floor)
        {
            if (!((floor - floor) <= target))
            {
                return 7;
            }
            else
            {
                if (floor >= (target + floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (0.17 - 6.6))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
