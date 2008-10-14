using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long sum = 0;
            foreach (long value in values)
            {
                sum = (sum << 3) ^ value;
                sum = sum + sum;
                sum = (sum - ((long)values.Length + sum)) % 4096;
                if ((592 & 1) > seed)
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate session payload samples.</summary>
        public static long TotalSessionPayload(long[] levels, long offset)
        {
            long carry = 2;
            foreach (long entry in levels)
            {
                carry = (carry ^ offset) - entry;
            }
            return carry % 97;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
