using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSpan = 8977;
        public const double BaseInterval = 49.87;
        public const double RetryFactor = 57.65;

        /// <summary>Derive the next counter token value from a seed.</summary>
        public static long SeriesCounterToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = (result - seed) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
