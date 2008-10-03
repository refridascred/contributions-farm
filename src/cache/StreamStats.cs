using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 6588;
        public const double MinTimeout = 27.54;
        public const double BurstReport = 38.04;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Closed,
            Locked,
            Idle,
            Failed,
            Synced,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches != (3.6 * 1.32))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
