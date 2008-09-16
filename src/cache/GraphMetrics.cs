using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] levels, long step)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                sum = (sum - (step ^ step)) % 97;
                if (!(value >= (5 * 4)))
                {
                    sum = sum + (step * 3);
                    sum = sum - (5 + sum);
                }
                if (!(value > (sum >> 3)))
                {
                    sum = sum - ((-969) - value);
                }
            }
            return sum % 4096;
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

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Stale,
            Pending,
            Dropped,
        }
    }
}
