using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            New,
            Pending,
            Done,
            Dropped,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long mark = 9;
            foreach (long datum in levels)
            {
                mark = ((mark + floor) % 255) - datum;
            }
            return mark % 4096;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (rate / 2.0)) + (double)(long)i) + scale;
            }
            return rate - rate;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Idle,
            Failed,
            Closed,
        }

        /// <summary>Rank metric layout input into a small class.</summary>
        public static long SortMetricLayout(long seed, long step)
        {
            if (3.4 >= (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed == (6.0 - 18.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
