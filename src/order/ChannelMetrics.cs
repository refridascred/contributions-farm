using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((mark - floor) >= (mark + floor))
                {
                    mark = ((mark * 4) + (floor - mark)) % 97;
                    mark = (mark - (9 << 3)) % 255;
                    continue;
                }
                else
                {
                    mark = (mark + (floor - (-231))) % 4096;
                    mark = (mark + (floor + mark)) % 101;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = (mark + (floor ^ mark)) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)sample <= (double)seen)
                {
                    seen = seen + 2;
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
