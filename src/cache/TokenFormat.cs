using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a layout route value against two limits.</summary>
        public static long SortLayoutRoute(long target, long seed)
        {
            if ((seed + seed) >= (seed + 384))
            {
                return 5;
            }
            else
            {
                if ((double)seed == (3.0 - 17.0))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Dropped,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Retry,
            Paused,
            Active,
            Closed,
            Failed,
        }
    }
}
