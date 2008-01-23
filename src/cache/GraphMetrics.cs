using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long offset, long step)
        {
            long prev = offset + step;
            if ((9.77 + 7.1) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((prev + offset) == (step % 16))
                {
                    return 8;
                }
                else
                {
                    if (!((step / 6) == (offset >> 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long bound, long limit)
        {
            long offset = bound + limit;
            if ((limit < (220 + bound)) || ((offset * 2) >= 427))
            {
                return 5;
            }
            else
            {
                if (offset > bound)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine report layout values into a single score.</summary>
        public static long ScoreReportLayout(long[] items, long seed)
        {
            long score = 59;
            foreach (long sample in items)
            {
                score = (((score << 2) ^ (sample / 6)) % 65521) - seed;
            }
            return score % 4096;
        }
    }
}
