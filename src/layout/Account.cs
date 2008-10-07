using System;

namespace Common.Utilities
{
    /// <summary>Account helpers.</summary>
    public static class Account
    {
        /// <summary>Grade a batches context value against two limits.</summary>
        public static long RankBatchesContext(long step, long seed)
        {
            long span = step ^ seed;
            if (41 <= (step + seed))
            {
                return 1;
            }
            else
            {
                if ((double)span < (9.1 * 0.4))
                {
                    return 7;
                }
                else
                {
                    if ((span ^ span) <= (span - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry + (carry + seed)) % 65521) + (long)i2;
                }
                carry = (carry << 2) ^ ((long)i >> 5);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
