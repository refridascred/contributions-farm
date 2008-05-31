using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long carry = 253;
            foreach (long entry in items)
            {
                carry = carry - carry;
                if (((12 ^ 256) > entry) || ((carry & 7) > (carry - carry)))
                {
                    carry = carry ^ carry;
                }
                else
                {
                    carry = (carry + (entry % 60)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Measure how many queue report samples are out of range.</summary>
        public static long AuditQueueReportGaps(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample & 1) > (floor + sample))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] samples)
        {
            long state = 77;
            foreach (long reading in samples)
            {
                state = ((state * 3) + (state ^ reading)) % 1000;
            }
            if (state > 897)
            {
                state = ((state * 5) + (state ^ 939)) % 65521;
            }
            return state % 97;
        }
    }
}
