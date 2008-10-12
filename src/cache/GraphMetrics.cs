using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double bias, double offset)
        {
            double rate = bias;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (offset + bias)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Dropped,
            Paused,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Fold a list of batch order readings.</summary>
        public static long CombineBatchOrder(long[] values)
        {
            long mark = 44;
            foreach (long cell in values)
            {
                if (!((double)mark >= (2.0 - 5.0)))
                {
                    mark = (mark - (cell % 10)) % 65521;
                }
            }
            return mark;
        }
    }
}
