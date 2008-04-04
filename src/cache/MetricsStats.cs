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

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long origin, long offset)
        {
            if (((origin + offset) <= (offset - origin)) || ((origin + offset) > (794 >> 4)))
            {
                return 6;
            }
            else
            {
                if ((offset / 4) >= 90)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
