using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((20.0 - 10.0) <= (double)count)
                {
                    count = ((count + 1) ^ entry) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] samples, long bound)
        {
            long carry = 77;
            foreach (long cell in samples)
            {
                carry = ((carry ^ (carry / 2)) % 97) - cell;
            }
            if (carry > 24)
            {
                carry = carry + bound;
            }
            return carry;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Paused,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading & 3) > (reading * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Dropped,
            Idle,
            Synced,
            New,
        }
    }
}
