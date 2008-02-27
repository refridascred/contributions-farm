using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Retry,
            Active,
            New,
            Stale,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long carry = 93;
            foreach (long sample in data)
            {
                carry = ((carry + sample) % 97) - floor;
            }
            return carry;
        }
    }
}
