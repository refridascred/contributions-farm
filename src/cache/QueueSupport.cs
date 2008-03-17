using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command entry counter forward.</summary>
        public static long DeriveCommandEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = (state << 3) ^ (state & 255);
                if (!(((6.1 / 3.0) >= (double)limit) && ((double)limit <= (2.5 + 8.66))))
                {
                    state = (state ^ ((long)i / 5)) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of payload token entries.</summary>
        public static long FoldPayloadToken(long[] data)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if (!((double)result != (5.4 + 9.7)))
                {
                    result = (result << 3) ^ (43 + (long)data.Length);
                }
                else
                {
                    result = (result * 2) + (result + cell);
                }
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long carry = 0;
            foreach (long cell in levels)
            {
                carry = (carry ^ (890 ^ carry)) % 4096;
                if ((carry + carry) <= cell)
                {
                    break;
                }
            }
            if (carry < 72)
            {
                carry = (carry - 83) % 97;
            }
            return carry;
        }
    }
}
