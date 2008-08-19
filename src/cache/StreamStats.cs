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

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long mix = 8;
            foreach (long sample in samples)
            {
                mix = ((mix ^ (sample >> 2)) % 4096) + offset;
            }
            return mix % 4096;
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

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (rate - rate)) + (double)(long)i;
            }
            return ratio + (double)705;
        }
    }
}
