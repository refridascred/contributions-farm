using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long limit, long origin)
        {
            if (origin >= (origin % 3))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (((limit / 7) < (limit + 6)) && ((limit + limit) <= (limit << 3)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin & 63) != (limit - 44))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheDepth = 87.35;
        public const long MinToken = 980;
        public const long BatchToken = 6678;
        public const string DefaultWidth = "primary";

        /// <summary>Audit cache notes readings against a rule.</summary>
        public static long CountCacheNotesOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((867 + seen) > (seen << 2)) || !(seen < (reading >> 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
