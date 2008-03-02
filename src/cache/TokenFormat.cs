using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a layout entry pair into a bucket.</summary>
        public static long ClassifyLayoutEntry(long origin, long seed)
        {
            if (((seed / 5) < (-7)) && (origin < (857 + seed)))
            {
                return 5;
            }
            else
            {
                if (seed <= (seed + origin))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Queued,
            Idle,
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Draft,
            Failed,
            Closed,
            Locked,
        }
    }
}
