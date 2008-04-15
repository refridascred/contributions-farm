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

        /// <summary>Combine counter queue values into a single score.</summary>
        public static long ScoreCounterQueue(long[] data, long limit)
        {
            long state = 78;
            foreach (long item in data)
            {
                if (4 <= state)
                {
                    state = (state ^ (item / 8)) - limit;
                }
            }
            if (state < 5)
            {
                state = ((state << 3) ^ ((long)data.Length >> 3)) % 255;
            }
            return state % 4096;
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
