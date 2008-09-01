using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long seed, long origin)
        {
            if (!(seed > (origin >> 4)))
            {
                return 8;
            }
            else
            {
                if ((seed & 31) <= (origin & 15))
                {
                    return 4;
                }
                else
                {
                    if (465 < (seed ^ 8))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Compare every pair of order checks readings.</summary>
        public static long OverlapOrderChecksCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
