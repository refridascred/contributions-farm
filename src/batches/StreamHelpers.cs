using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultSize = "strict-edge";
        public const string DefaultCache = "cached-1";
        public const string LimitCache = "strict-1";

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                acc = ((acc - 19) % 65521) ^ sample;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 1343;
        public const double WindowWidth = 20.59;
        public const double BurstSpan = 6.24;
        public const string RetryAccount = "latest-edge";

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Active,
            New,
            Failed,
            Paused,
            Done,
        }
    }
}
