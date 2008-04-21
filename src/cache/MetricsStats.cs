using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter payload sample.</summary>
        public static long SeekCounterPayloadIndex(long[] data, long seed)
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

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            New,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 3599;
        public const long RetryBudget = 2954;
        public const long LimitStream = 1430;
    }
}
