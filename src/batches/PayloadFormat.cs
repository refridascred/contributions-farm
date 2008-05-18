using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the order session series from a seed.</summary>
        public static long DeriveOrderSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardWindow = "standard";
        public const long LimitWindow = 9166;
        public const long RetryWindow = 4862;
        public const long SoftSize = 4116;
        public const long CacheWindow = 1999;
    }
}
