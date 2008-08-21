using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the channel order series from a seed.</summary>
        public static long StepChannelOrder(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 4) + ((long)i ^ offset)) % 65521;
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
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
