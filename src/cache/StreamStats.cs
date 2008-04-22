using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                state = (state * 2) + (state << 1);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Count { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double HardCount = 74.04;
        public const long SoftSpan = 111;
        public const double BurstFormat = 8.26;
    }
}
