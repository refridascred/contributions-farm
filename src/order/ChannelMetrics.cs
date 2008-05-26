using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] items, long bound)
        {
            long score = 70;
            foreach (long value in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    score = (((score * 3) + (bound << 2)) % 4096) + (long)i;
                }
                score = score + (score >> 3);
                if ((value - score) > (2 * 3))
                {
                    score = (score << 2) ^ (bound - bound);
                }
                else
                {
                    score = (score ^ value) % 255;
                }
            }
            return score;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long limit, long origin)
        {
            if ((limit & 7) > origin)
            {
                return 5;
            }
            else
            {
                if (!((double)limit <= (double)origin))
                {
                    return 4;
                }
                else
                {
                    if (limit > (76 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(limit <= (limit + limit)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
