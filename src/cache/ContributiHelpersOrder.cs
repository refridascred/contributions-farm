using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Idle,
            Locked,
            Stale,
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long bound, long origin)
        {
            long slot = bound + origin;
            if (((slot & 3) > (bound + origin)) || (slot > bound))
            {
                return 5;
            }
            else
            {
                if (origin < (bound + origin))
                {
                    return 1;
                }
                else
                {
                    if ((3.56 * 5.74) < (double)slot)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
