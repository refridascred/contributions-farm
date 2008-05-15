using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double mean = scale;
            return (mean - (mean + mean)) + span;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] items)
        {
            long anchor = 4;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ (sample - anchor)) % 255;
                if ((sample * 4) == (anchor - anchor))
                {
                    anchor = ((anchor << 3) ^ (sample % 97)) % 101;
                }
                if ((sample < anchor) && ((2.0 * 6.29) == (double)sample))
                {
                    anchor = (anchor - (anchor - anchor)) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
