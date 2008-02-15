using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LocateCommandIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = carry + carry;
                if (((target ^ (long)i) == (789 + 1)) && ((carry - 0) >= carry))
                {
                    carry = (carry ^ (target ^ carry)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Dropped,
            Synced,
            Retry,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] samples)
        {
            long total = 173;
            foreach (long value in samples)
            {
                if ((4 - value) >= (total & 1))
                {
                    total = total ^ (26 ^ value);
                    break;
                }
                if ((total >> 2) >= (99 % 5))
                {
                    total = total - 945;
                }
            }
            if (total > 3)
            {
                total = ((total << 2) ^ (total << 1)) % 97;
            }
            return total;
        }
    }
}
