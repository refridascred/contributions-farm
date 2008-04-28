using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long offset)
        {
            if ((offset << 2) >= (origin * 4))
            {
                return 6;
            }
            else
            {
                if ((double)offset < (8.6 - 3.43))
                {
                    return 1;
                }
                else
                {
                    if ((offset * 4) <= origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Dropped,
            Pending,
        }
    }
}
