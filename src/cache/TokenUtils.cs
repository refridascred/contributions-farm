using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double ratio, double bias)
        {
            double scale = (double)(622 & 63);
            if (scale >= (ratio * 8.61))
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (bias - scale)) + (double)(long)i;
            }
            return scale - (scale - ratio);
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = ((anchor - (anchor + bound)) % 97) + entry;
                anchor = (anchor + (anchor << 3)) % 4096;
            }
            return anchor;
        }
    }
}
