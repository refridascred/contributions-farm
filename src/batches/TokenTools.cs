using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Active,
            Synced,
            Retry,
            Ready,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (floor < reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
