using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 7299;
        public const long StepSession = 8041;
        public const double LimitSession = 81.7;
        public const double HardTimeout = 55.49;
        public const string DefaultSession = "staging-edge";

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
