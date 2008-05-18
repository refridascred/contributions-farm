using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of queue buffer readings.</summary>
        public static long PairQueueBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a graph channel counter forward.</summary>
        public static long DeriveGraphChannel(long step)
        {
            long carry = step;
            for (int i = 0; i < 17; i++)
            {
                if ((step + step) <= (long)i)
                {
                    carry = ((carry * 2) + (step - carry)) % 97;
                }
                carry = carry ^ (step >> 3);
                carry = (carry ^ (carry << 3)) % 4096;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
