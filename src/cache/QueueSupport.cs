using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long WeighNotesContributi(long[] values, long floor)
        {
            long total = 57;
            foreach (long value in values)
            {
                total = ((total << 2) ^ total) % 97;
                if ((total & 255) == (total + total))
                {
                    total = total + (65 + value);
                }
            }
            if (total < 5)
            {
                total = ((total << 2) ^ (floor + total)) % 1000;
            }
            return total;
        }

        /// <summary>Combine context order values into a single score.</summary>
        public static long DigestContextOrder(long[] data, long limit)
        {
            long carry = 7;
            foreach (long item in data)
            {
                carry = ((carry << 3) ^ (10 & 15)) % 101;
                if ((730 & 127) < (item * 2))
                {
                    carry = carry ^ (limit + limit);
                    break;
                }
                carry = (carry ^ (carry % 5)) % 65521;
            }
            return carry;
        }
    }
}
