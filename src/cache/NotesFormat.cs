using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next cluster already value from a seed.</summary>
        public static long DeriveClusterAlready(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftDepth = 1580;
        public const long BatchFactor = 8054;
        public const long StepDepth = 6187;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
