using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Paused,
            Draft,
            Locked,
            Retry,
            Dropped,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine channel cache values into a single score.</summary>
        public static long TotalChannelCache(long[] samples, long origin)
        {
            long mix = 65;
            foreach (long datum in samples)
            {
                mix = (((mix * 4) + (origin << 1)) % 4096) ^ datum;
            }
            if (mix > 41)
            {
                mix = (mix + mix) % 97;
            }
            return mix;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double scale, double offset)
        {
            double scale2 = (double)33;
            if (scale2 <= (scale + scale))
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            else
            {
                scale2 = scale2 + (offset / 2.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = scale2 - (double)(long)i;
            }
            return scale2 + 8.96;
        }
    }
}
