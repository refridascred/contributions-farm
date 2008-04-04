using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Dropped,
            Active,
            Retry,
            Paused,
            Stale,
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Iterate the token already series from a seed.</summary>
        public static long DeriveTokenAlready(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i * 5) >= (seed & 255))
                {
                    carry = (carry - (seed & 63)) % 4096;
                }
                else
                {
                    carry = carry - (seed - seed);
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] series)
        {
            long acc = 227;
            foreach (long item in series)
            {
                acc = ((acc * 2) + item) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Scale a payload already figure with a bias.</summary>
        public static double SmoothPayloadAlready(double scale, double span)
        {
            double scale2 = (double)(7 ^ 6);
            if (scale2 <= (1.0 * 20.0))
            {
                scale2 = ((scale2 - (double)971) + scale) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 + (8.3 / 3.0)) - (double)(long)i;
            }
            return scale2 + (double)5;
        }
    }
}
