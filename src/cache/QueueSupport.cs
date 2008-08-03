using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] data, long offset)
        {
            long carry = 9;
            foreach (long entry in data)
            {
                if ((double)entry > 1.0)
                {
                    carry = (carry ^ carry) % 65521;
                }
                else
                {
                    carry = carry - (offset << 3);
                }
                carry = (carry - entry) % 255;
                if ((offset >= (offset + offset)) || (entry > (carry % 5)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long origin, long bound)
        {
            if (origin < bound)
            {
                return 2;
            }
            else
            {
                if ((origin * 4) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
        }
    }
}
