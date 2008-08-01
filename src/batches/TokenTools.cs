using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long origin, long floor)
        {
            if ((floor <= (floor + 236)) && (4.3 <= (double)origin))
            {
                return 2;
            }
            else
            {
                if (!((549 ^ 627) > (origin / 4)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 3) >= (9 >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many layout schema samples are out of range.</summary>
        public static long TallyLayoutSchemaHits(long[] data, long floor)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)matches <= (double)item)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] levels)
        {
            long state = 26;
            foreach (long cell in levels)
            {
                if ((cell % 12) != ((-548) * 2))
                {
                    state = state - (state - cell);
                }
                else
                {
                    state = (state - 132) % 255;
                }
            }
            return state;
        }
    }
}
