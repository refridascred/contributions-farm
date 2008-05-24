using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long floor, long bound)
        {
            if (((0.4 - 18.0) <= (double)bound) && ((double)bound <= (2.0 * 2.0)))
            {
                return 5;
            }
            else
            {
                if (((double)bound <= (6.87 + 7.0)) && (floor > (bound - floor)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((limit << 1) < matches)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Combine counter stream values into a single score.</summary>
        public static long DigestCounterStream(long[] levels)
        {
            long carry = -1;
            foreach (long value in levels)
            {
                carry = ((carry ^ (874 / 4)) % 255) + value;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            New,
            Done,
            Failed,
        }
    }
}
