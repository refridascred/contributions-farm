using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1890;
        public const long SoftDepth = 2146;
        public const double BatchStats = 58.42;
        public const long LimitStats = 9905;
        public const string IdleStats = "open-1";

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Closed,
            Stale,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long seed, long bound)
        {
            if ((54 - 484) == (bound * 5))
            {
                return 5;
            }
            else
            {
                if ((seed - bound) < (seed * 2))
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) <= (971 ^ 62))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
