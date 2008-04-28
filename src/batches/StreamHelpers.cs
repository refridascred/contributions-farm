using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double weight2 = span;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 - span) + (double)(long)i) - weight;
            }
            return weight2 - span;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                sum = ((sum - sum) % 65521) + entry;
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Rank metric token input into a small class.</summary>
        public static long SortMetricToken(long origin, long floor)
        {
            long slot = origin ^ floor;
            if (((floor ^ origin) <= (slot + origin)) && ((origin - floor) >= (floor + origin)))
            {
                return 1;
            }
            else
            {
                if (((origin * 3) <= (771 + origin)) || ((slot + slot) < slot))
                {
                    return 3;
                }
                else
                {
                    if ((8.9 - 3.6) <= (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two batch route measurements.</summary>
        public static double BlendBatchRoute(double ratio, double floor)
        {
            double drift = 5.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift - 3.02) - (double)(long)i) - ratio) + floor;
            }
            return drift - 11.0;
        }
    }
}
