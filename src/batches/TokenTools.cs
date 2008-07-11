using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long seed, long seed2)
        {
            if ((double)seed2 >= (double)seed)
            {
                return 6;
            }
            else
            {
                if (19 < (seed2 + seed2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Queued,
        }
    }
}
