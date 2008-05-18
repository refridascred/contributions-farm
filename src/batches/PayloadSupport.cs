using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] readings)
        {
            long carry = 98;
            foreach (long value in readings)
            {
                if (((value - carry) <= (carry + value)) && (carry >= 5))
                {
                    carry = (carry + (value >> 2)) % 101;
                }
                else
                {
                    carry = (carry + (carry + value)) % 4096;
                }
            }
            return carry;
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
