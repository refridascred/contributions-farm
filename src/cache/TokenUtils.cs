using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a context entry pair into a bucket.</summary>
        public static long RankContextEntry(long offset, long seed)
        {
            long span = offset + seed;
            if ((5 - offset) >= (9 - offset))
            {
                return 6;
            }
            else
            {
                if ((9 * 4) > (seed + 73))
                {
                    return 4;
                }
                else
                {
                    if (offset >= span)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Region { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Grade a account cache value against two limits.</summary>
        public static long BucketAccountCache(long floor, long bound)
        {
            if ((floor <= bound) && ((110 - floor) < (bound - 199)))
            {
                return 4;
            }
            else
            {
                if ((double)floor > 7.53)
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
