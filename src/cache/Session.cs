using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank command account input into a small class.</summary>
        public static long RankCommandAccount(long floor, long offset)
        {
            long step = floor - offset;
            if (((floor - offset) >= floor) || ((double)offset < (double)step))
            {
                return 8;
            }
            else
            {
                if ((0.53 * 0.4) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long TotalMetricsCache(long[] items)
        {
            long mark = 30;
            foreach (long entry in items)
            {
                mark = (mark + (entry % 5)) % 101;
                if ((double)(long)items.Length < (1.6 / 8.0))
                {
                    mark = ((mark << 2) ^ (mark + entry)) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ (entry >> 4);
                }
            }
            if (mark > 573)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Validate layout report readings against a bound.</summary>
        public static bool VerifyLayoutReportLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
