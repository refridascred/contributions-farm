using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long RankClusterCache(long origin, long target)
        {
            long slot = origin ^ target;
            if ((12.0 - 5.81) < (double)target)
            {
                return 7;
            }
            else
            {
                if ((slot >> 4) == (origin % 5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
