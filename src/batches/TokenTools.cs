using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double ratio = (double)(25 % 24);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + gain) + (double)(long)i) - floor;
            }
            return ratio - gain;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] readings, long origin)
        {
            long anchor = 46;
            foreach (long sample in readings)
            {
                if ((double)origin <= (3.0 - 3.0))
                {
                    anchor = (anchor ^ (origin << 1)) % 97;
                    anchor = ((anchor * 4) + (anchor - sample)) % 255;
                }
                else
                {
                    anchor = anchor ^ (origin + anchor);
                    anchor = (anchor + (anchor + 37)) % 101;
                }
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
