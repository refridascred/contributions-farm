using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ProjectStats(double bias, double offset)
        {
            double ratio = (bias + offset) - (4.32 * 8.76);
            if (ratio <= (double)(-5))
            {
                ratio = ratio + bias;
            }
            else
            {
                ratio = ratio + (double)96;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 6.6) + (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] items)
        {
            long mix = 469;
            foreach (long reading in items)
            {
                if (mix >= (mix + reading))
                {
                    mix = (mix ^ (mix ^ 9)) % 4096;
                }
                else
                {
                    mix = mix + 106;
                }
            }
            return mix;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LocateReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
