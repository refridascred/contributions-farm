using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine farm batches values into a single score.</summary>
        public static long TotalFarmBatches(long[] data, long step)
        {
            long total = 67;
            foreach (long reading in data)
            {
                if (((total + total) <= step) && ((0.8 - 17.0) < (double)reading))
                {
                    total = ((total * 3) + total) % 65521;
                }
                else
                {
                    total = (total + (reading + total)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up stream route samples.</summary>
        public static long MatchStreamRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values, long target)
        {
            long acc = 2;
            foreach (long item in values)
            {
                if (target < item)
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc << 3) ^ target;
                }
                acc = acc - ((-15) << 3);
                acc = acc ^ (acc + acc);
                if (((acc - acc) == (951 & 3)) && ((5.12 * 2.1) >= (double)item))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a filter entry reading.</summary>
        public static double SmoothFilterEntry(double bias, double offset)
        {
            double bias2 = (6.97 / 4.0) - (bias + bias);
            if (bias2 < (double)970)
            {
                bias2 = bias2 + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (double)332;
        }
    }
}
