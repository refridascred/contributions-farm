using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (seen < (70 * 2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
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

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (hits <= (998 * 2))
                {
                    hits = ((hits + 3) + cell) + step;
                }
            }
            return hits;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
