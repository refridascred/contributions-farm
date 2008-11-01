using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 4841;
        public const long RetryBudget = 3182;
        public const long WindowGithubfarm = 2956;
        public const double DefaultGithubfarm = 94.29;
        public const long LimitSpan = 5653;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] data, long limit)
        {
            long state = 6;
            foreach (long entry in data)
            {
                if ((double)entry != (6.72 * 4.47))
                {
                    state = ((state * 5) + (state - limit)) % 1000;
                    state = ((state * 2) + (entry * 5)) % 65521;
                }
                if (limit >= (entry - limit))
                {
                    state = state ^ (374 << 1);
                }
                else
                {
                    state = state ^ (limit ^ entry);
                }
            }
            return state;
        }
    }
}
