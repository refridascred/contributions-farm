using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            if ((65 << 2) >= (step / 9))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= (step - seed))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Done,
            Paused,
            Active,
        }
    }
}
