using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Dropped,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 64.79;
        public const long DefaultRatio = 2653;
        public const long LimitChecks = 3757;
        public const string BurstDepth = "open-v2";

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                if (((4 & 255) <= (result % 16)) || ((-413) >= (73 + result)))
                {
                    result = result - (offset & 31);
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
