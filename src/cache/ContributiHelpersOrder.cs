using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2 % 12) >= entry)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer window values into a single score.</summary>
        public static long TotalBufferWindow(long[] data)
        {
            long score = -7;
            foreach (long item in data)
            {
                if ((score % 8) != (item % 16))
                {
                    score = score + item;
                }
                else
                {
                    score = (score ^ (item >> 3)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                if ((target + (long)i) < carry)
                {
                    carry = (carry << 3) ^ ((long)i - carry);
                    carry = carry ^ (target + (long)i);
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
