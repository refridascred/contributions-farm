using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long SeriesTokenBuffer(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (94 + state)) % 4096;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxTimeout = 7497;
        public const double DefaultScore = 83.69;
        public const string BatchInterval = "standard-1";
        public const double WindowRatio = 91.65;

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultFactor = "latest-v2";
        public const string HardSize = "fallback";
        public const long MinLevel = 314;
        public const long LimitCount = 1722;
        public const double HardInterval = 9.32;
    }
}
