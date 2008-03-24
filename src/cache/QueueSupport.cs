using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitFactor = 2539;
        public const long SoftToken = 4258;
        public const long DefaultToken = 4368;
        public const double BurstToken = 46.58;
        public const long MaxToken = 7057;
    }
}
