using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = ((sum - (seed * 5)) % 101) + (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] values, long bound)
        {
            long acc = 107;
            foreach (long item in values)
            {
                acc = (((acc * 3) + (bound % 7)) % 65521) ^ item;
                acc = ((acc * 3) + acc) % 4096;
            }
            return acc % 65521;
        }
    }
}
