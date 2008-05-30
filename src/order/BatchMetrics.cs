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

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((double)seed >= (5.25 / 2.0)) && ((seed & 63) <= state))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples)
        {
            long mark = 37;
            foreach (long datum in samples)
            {
                mark = (((mark << 2) ^ 27) % 101) + datum;
            }
            return mark % 4096;
        }
    }
}
