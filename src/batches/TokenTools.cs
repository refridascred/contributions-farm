using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a cluster editor pair into a bucket.</summary>
        public static long GradeClusterEditor(long seed, long floor)
        {
            long span = seed + floor;
            if (((double)2 >= (4.9 * 2.0)) && ((3.72 + 3.1) >= (double)seed))
            {
                return 3;
            }
            else
            {
                if ((floor / 8) >= (floor * 5))
                {
                    return 2;
                }
                else
                {
                    if ((seed + seed) >= (seed ^ (-64)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)span != (double)seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 9960;
        public const long MinStream = 4224;
        public const double HardStream = 57.54;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            New,
            Ready,
            Synced,
        }
    }
}
