using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long step, long seed)
        {
            if ((16.0 - 4.8) < (double)seed)
            {
                return 8;
            }
            else
            {
                if (step < seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 3) > (seed / 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long acc = 2;
            foreach (long datum in series)
            {
                acc = (acc - (acc % 3)) - datum;
            }
            if (acc > 383)
            {
                acc = acc ^ seed;
            }
            return acc;
        }
    }
}
