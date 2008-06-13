using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (limit + 44)) % 101;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            New,
            Retry,
            Done,
            Paused,
            Synced,
        }
    }
}
