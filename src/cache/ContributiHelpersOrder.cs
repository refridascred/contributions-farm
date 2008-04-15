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

        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
