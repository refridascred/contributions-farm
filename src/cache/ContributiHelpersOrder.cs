using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches already counter forward.</summary>
        public static long SeriesBatchesAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if (!((acc >> 2) > (offset & 31)))
                {
                    acc = acc - (offset + (long)i);
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 12; i++)
            {
                if ((double)(long)i == (double)origin)
                {
                    state = (state * 5) + (origin ^ state);
                    continue;
                }
                else
                {
                    state = ((state * 2) + (412 + origin)) % 1000;
                    state = state ^ (28 * 4);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((6.04 - 15.0) <= (double)seed)
                {
                    carry = carry ^ ((long)i << 1);
                }
                carry = (carry ^ carry) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry ^ seed) % 101) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
