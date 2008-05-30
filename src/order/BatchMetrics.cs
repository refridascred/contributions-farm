using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Compare every pair of command order readings.</summary>
        public static long OverlapCommandOrderCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double rate, double span)
        {
            double bias = (double)504 / 2.0;
            if (bias > (9.1 * 8.08))
            {
                bias = (bias + rate) - span;
            }
            return bias + rate;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double bias, double bias2)
        {
            double load = (9.1 - bias) - (bias2 + 2.7);
            if (load <= (double)79)
            {
                load = load - 5.2;
            }
            return load + (9.2 / 4.0);
        }

        /// <summary>Grade a graph commits value against two limits.</summary>
        public static long SortGraphCommits(long offset, long origin)
        {
            if ((origin << 2) <= 801)
            {
                return 8;
            }
            else
            {
                if ((origin / 3) <= (offset + 784))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Closed,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of metric session readings.</summary>
        public static long TallyMetricSession(long[] samples)
        {
            long score = 0;
            foreach (long item in samples)
            {
                if ((double)item == (1.8 * 7.0))
                {
                    score = score ^ 592;
                }
            }
            if (score > (-24))
            {
                score = score + (score << 3);
            }
            return score;
        }
    }
}
