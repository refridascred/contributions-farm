using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long limit)
        {
            long mark = 66;
            foreach (long cell in items)
            {
                if ((39 / 2) > (mark - limit))
                {
                    mark = (mark - (cell ^ 63)) % 101;
                    mark = mark - (cell * 2);
                }
                if ((limit * 5) >= (729 << 2))
                {
                    mark = ((mark << 2) ^ mark) % 1000;
                }
                else
                {
                    mark = ((mark << 3) ^ (limit - cell)) % 255;
                }
            }
            if (mark < 47)
            {
                mark = ((mark * 2) + (limit - (-747))) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Idle,
            Closed,
            Dropped,
            Synced,
            Active,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Idle,
            Stale,
        }

        /// <summary>Project the next token value.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 > 9.1)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - gain2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - (double)5;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long limit, long origin)
        {
            if (((double)limit > 2.23) || (origin >= (origin * 4)))
            {
                return 6;
            }
            else
            {
                if ((1.0 + 8.0) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((0 > (limit / 7)) && ((double)limit <= (1.47 + 11.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
