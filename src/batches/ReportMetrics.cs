using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank already batch input into a small class.</summary>
        public static long RankAlreadyBatch(long origin, long seed)
        {
            long diff = origin - seed;
            if ((double)diff < (double)2)
            {
                return 3;
            }
            else
            {
                if ((diff > (origin + diff)) && (diff >= (origin % 2)))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin > (4.8 - 4.92)) && ((double)diff == (9.5 - 20.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long MatchStreamCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
