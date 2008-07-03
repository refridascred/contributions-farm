using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark ^ (floor + floor)) % 1000;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next record value.</summary>
        public static double ScaleRecord(double scale, double offset)
        {
            double scale2 = (double)0 - (double)99;
            for (int i = 0; i < 7; i++)
            {
                scale2 = ((scale2 - scale2) + (double)(long)i) + offset;
            }
            return scale2 - (scale - scale);
        }

        /// <summary>Check that every channel commits entry stays within the limit.</summary>
        public static bool VerifyChannelCommitsRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
