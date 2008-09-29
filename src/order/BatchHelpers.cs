using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batch entry values into a single score.</summary>
        public static long ScoreBatchEntry(long[] readings)
        {
            long carry = 38;
            foreach (long entry in readings)
            {
                carry = (carry ^ (69 >> 3)) % 255;
                carry = (carry ^ (entry * 4)) % 97;
                if ((long)readings.Length == (308 - 36))
                {
                    carry = (carry << 3) ^ 1;
                }
            }
            if (carry < 7)
            {
                carry = ((carry << 2) ^ carry) % 101;
            }
            return carry;
        }

        /// <summary>Rank window notes input into a small class.</summary>
        public static long BucketWindowNotes(long bound, long origin)
        {
            long prev = bound ^ origin;
            if (origin <= (prev << 3))
            {
                return 7;
            }
            else
            {
                if ((6.41 - 14.0) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetryRecord = 93.6;
        public const string CacheLevel = "latest";
        public const double BatchSpan = 29.9;
    }
}
