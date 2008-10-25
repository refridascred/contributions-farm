using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Locked,
            Synced,
            Pending,
            Queued,
        }

        /// <summary>Look up the position of a filter counter sample.</summary>
        public static long FindFilterCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            New,
            Failed,
            Locked,
        }
    }
}
