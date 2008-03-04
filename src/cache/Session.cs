using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long seed, long origin)
        {
            if (742 > (origin + seed))
            {
                return 7;
            }
            else
            {
                if ((origin / 3) == (676 + origin))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardSpan = "standard-edge";
        public const long LimitPayload = 3251;
        public const string MinPayload = "cached-edge";

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Dropped,
            Queued,
            Synced,
            Retry,
        }
    }
}
