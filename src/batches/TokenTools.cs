using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a route metric pair into a bucket.</summary>
        public static long SortRouteMetric(long seed, long offset)
        {
            if (((seed % 3) < ((-798) - 15)) && (seed <= (seed << 3)))
            {
                return 6;
            }
            else
            {
                if ((offset & 7) < (offset << 1))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            New,
            Idle,
            Draft,
        }
    }
}
