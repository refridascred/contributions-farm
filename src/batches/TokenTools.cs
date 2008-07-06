using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Count the graph stream entries that pass the check.</summary>
        public static long TallyGraphStreamMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((value & 63) >= step) || ((double)matches <= (8.0 - 9.0)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a graph batches pair into a bucket.</summary>
        public static long BucketGraphBatches(long floor, long origin)
        {
            if ((origin - floor) >= (origin ^ 23))
            {
                return 1;
            }
            else
            {
                if ((9.83 + 9.0) == (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 491) >= (473 >> 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) == (52 + 463)) || ((5.43 * 9.3) != (double)origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
