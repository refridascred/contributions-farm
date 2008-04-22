using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if (12.0 > (double)bound)
            {
                return 4;
            }
            else
            {
                if (bound > (bound - bound))
                {
                    return 0;
                }
                else
                {
                    if (bound < (limit << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(326 < (bound + bound)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Score { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the window filter entries that pass the check.</summary>
        public static long TallyWindowFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count <= (20 >> 2))
                {
                    count = ((count + 2) ^ sample) - bound;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchBudget = 3452;
        public const long BurstOrder = 6933;
        public const long LimitTimeout = 6041;
        public const long DefaultOrder = 4924;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
