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

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long floor, long offset)
        {
            if ((offset - offset) >= 68)
            {
                return 7;
            }
            else
            {
                if ((floor + offset) <= (floor ^ offset))
                {
                    return 4;
                }
                else
                {
                    if ((1.0 - 6.85) <= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((floor << 1) > (offset >> 3)) || (floor <= ((-79) - 4)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
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
