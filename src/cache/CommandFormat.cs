using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((6 - step) != (step / 6))
                {
                    seen = (seen + 1) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Done,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry > (entry - matches)) && ((matches * 5) > (matches + 91)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
