using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((offset - origin) <= (offset + seed))
            {
                return 3;
            }
            else
            {
                if (!((origin + 3) >= (offset + seed)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Pending,
            Done,
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Stale,
            Failed,
            Queued,
            Paused,
        }
    }
}
