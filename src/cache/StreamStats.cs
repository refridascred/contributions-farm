using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Paused,
            Stale,
            Retry,
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                if (seed <= (seed ^ 812))
                {
                    mix = ((mix * 3) + seed) % 65521;
                    break;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = result + (floor + floor);
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double rate = (double)(90 + 3);
            return (rate - (bias2 + rate)) + bias;
        }
    }
}
