using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of graph session readings.</summary>
        public static long OverlapGraphSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
