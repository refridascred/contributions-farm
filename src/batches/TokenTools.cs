using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Locked,
            New,
            Idle,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Queued,
            Synced,
            Closed,
            New,
            Idle,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((hits + hits) < (sample + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
