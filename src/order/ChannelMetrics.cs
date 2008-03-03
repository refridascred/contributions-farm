using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((matches << 2) < seed) || (5.37 >= 3.9))
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] series, long target)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = (((mark ^ 12) % 4096) ^ value) + target;
            }
            return mark;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain + rate)) + (double)(long)i;
            }
            return gain - (2.12 + floor);
        }
    }
}
