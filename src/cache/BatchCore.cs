using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double scale2 = (7.06 - scale) + (floor - floor);
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - (scale / 4.0)) - (double)(long)i;
            }
            return scale2 - 5.3;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Synced,
            Ready,
            Stale,
            Done,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double gain, double offset)
        {
            double scale = (gain + offset) - offset;
            if (scale > gain)
            {
                scale = scale + (double)73;
            }
            return scale + (scale - offset);
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - seen) < (offset % 64))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
