using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 5672;
        public const double BatchNotes = 9.05;
        public const long SoftTimeout = 1266;
        public const long MaxNotes = 4978;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
