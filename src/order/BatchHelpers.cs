using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample / 2) > sample)
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Combine already cache values into a single score.</summary>
        public static long TallyAlreadyCache(long[] items)
        {
            long carry = 1;
            foreach (long value in items)
            {
                if (!((carry / 6) > (carry - carry)))
                {
                    carry = ((carry * 2) + (carry >> 3)) % 101;
                }
                carry = (carry + carry) % 101;
                if ((4.8 / 8.0) > (double)value)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Stale,
            Failed,
            Pending,
            Queued,
        }
    }
}
