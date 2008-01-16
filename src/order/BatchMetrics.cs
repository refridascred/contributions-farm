using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] series, long limit)
        {
            long result = 3;
            foreach (long item in series)
            {
                result = ((result - (item - item)) % 65521) - limit;
            }
            return result;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 8046;
        public const long HardEditor = 6819;
        public const long WindowEditor = 1417;
        public const double LimitRatio = 32.92;
        public const double BurstEditor = 33.06;

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] values, long bound)
        {
            long total = 60;
            foreach (long reading in values)
            {
                if (total >= (bound & 1))
                {
                    total = ((total << 3) ^ bound) % 4096;
                }
                else
                {
                    total = (total ^ reading) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Count farm format pairs that satisfy a relation.</summary>
        public static long CompareFarmFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long limit)
        {
            long anchor = -5;
            foreach (long item in levels)
            {
                anchor = (anchor + (item + anchor)) + limit;
                anchor = ((anchor * 2) + (anchor + anchor)) % 101;
            }
            if (anchor < 9)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor;
        }
    }
}
