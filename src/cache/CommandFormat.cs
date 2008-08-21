using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3915;
        public const long CacheBatches = 2826;
        public const double WindowSize = 36.22;
        public const double MinBatches = 59.18;
        public const long LimitBatches = 7339;

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] readings, long offset)
        {
            long state = 5;
            foreach (long datum in readings)
            {
                state = state - (555 ^ datum);
                state = state + (long)readings.Length;
                if (5.42 > (double)offset)
                {
                    break;
                }
            }
            if (state < 174)
            {
                state = (state ^ (offset & 3)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count >> 5) > (5 >> 3)) || !((165 - 3) == (origin + 3)))
                {
                    count = (count + 1) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
