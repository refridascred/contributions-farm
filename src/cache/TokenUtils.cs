using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 5819;
        public const string WindowInterval = "open";
        public const double BurstRatio = 77.61;

        /// <summary>Adjust a already cache reading.</summary>
        public static double SmoothAlreadyCache(double rate, double span)
        {
            double ratio = (span * 3.4) - rate;
            if (ratio < (double)8)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (span + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)53) - (double)(long)i;
            }
            return ratio + (rate + span);
        }

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((5 <= reading) && ((18.0 * 2.3) <= (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
