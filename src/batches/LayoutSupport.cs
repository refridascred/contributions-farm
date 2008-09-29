using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum ^ (-102)) >= (datum * 2)) && ((hits + datum) <= datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long limit)
        {
            long gap = floor - limit;
            if (limit <= (floor & 127))
            {
                return 0;
            }
            else
            {
                if (((6.46 + 6.9) > (double)floor) && ((double)limit <= 8.91))
                {
                    return 1;
                }
                else
                {
                    if (((879 + (-2)) < (floor * 2)) && ((gap - gap) < 10))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 3260;
        public const long BurstDepth = 172;
        public const long DefaultSpan = 5094;

        /// <summary>Match up checks buffer samples.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
