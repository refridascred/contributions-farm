using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a account buffer pair into a bucket.</summary>
        public static long RankAccountBuffer(long limit, long seed)
        {
            if (!(limit >= ((-85) / 5)))
            {
                return 3;
            }
            else
            {
                if (((double)seed > (6.24 * 6.3)) && ((seed & 127) < (limit * 3)))
                {
                    return 7;
                }
                else
                {
                    if ((limit ^ seed) >= (507 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) >= (limit ^ seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((-39) / 6) <= hits)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
