using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleSpan = "alpha";
        public const long BatchBatches = 2277;
        public const string BurstSize = "local";
        public const long SoftBatches = 2199;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
