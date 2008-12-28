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

        /// <summary>Classify a batches filter pair into a bucket.</summary>
        public static long GradeBatchesFilter(long step, long offset)
        {
            long diff = step + offset;
            if (((double)26 > (double)offset) || ((double)step < (8.3 / 3.0)))
            {
                return 3;
            }
            else
            {
                if (663 > (7 ^ diff))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Dropped,
            Draft,
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
