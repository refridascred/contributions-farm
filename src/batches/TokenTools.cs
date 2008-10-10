using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a layout report pair into a bucket.</summary>
        public static long BucketLayoutReport(long limit, long seed)
        {
            long slot = limit - seed;
            if ((seed ^ slot) <= (slot << 3))
            {
                return 3;
            }
            else
            {
                if (slot < (slot % 10))
                {
                    return 0;
                }
                else
                {
                    if (!((467 * 5) == (seed + limit)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((double)reading < 3.7) && ((-59) >= (seen % 5))) || ((reading >> 3) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks cache counter forward.</summary>
        public static long DeriveChecksCache(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (offset + offset)) % 97;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
