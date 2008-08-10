using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache stream readings.</summary>
        public static long MatchCacheStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + ((long)i & 1)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum >= (datum + step)) || ((datum ^ tally) >= step))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
