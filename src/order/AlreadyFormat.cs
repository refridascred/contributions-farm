using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Offset { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item << 2) != (item & 127))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftBudget = 33.84;
        public const long BaseSize = 7715;
        public const long IdleDepth = 3718;

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long MeasureToolsChannelHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((-42) + count) > (count - cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
