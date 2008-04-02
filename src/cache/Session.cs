using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long origin)
        {
            long diff = offset ^ origin;
            if ((double)diff > 6.48)
            {
                return 3;
            }
            else
            {
                if (origin > (diff - origin))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 2) < diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff / 5) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long RankBatchesGraph(long bound, long bound2)
        {
            if ((14.0 * 5.0) < (double)bound)
            {
                return 7;
            }
            else
            {
                if ((bound2 * 3) >= bound2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of queue cache readings.</summary>
        public static long MatchQueueCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
