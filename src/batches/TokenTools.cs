using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Stale,
            Idle,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Queued,
            Stale,
            New,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long bound, long target)
        {
            long cur = bound - target;
            if (3.7 < (double)target)
            {
                return 7;
            }
            else
            {
                if ((cur <= (target + cur)) && ((double)target <= (8.9 * 20.0)))
                {
                    return 3;
                }
                else
                {
                    if (target > (target % 8))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((cur + bound) < (target - bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
