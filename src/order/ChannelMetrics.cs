using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples)
        {
            long mark = 48;
            foreach (long cell in samples)
            {
                if ((double)cell == (1.1 * 4.39))
                {
                    mark = mark - (mark & 63);
                }
                mark = (mark - (cell % 12)) % 101;
            }
            if (mark > 90)
            {
                mark = (mark - (mark >> 1)) % 255;
            }
            return mark;
        }
    }
}
