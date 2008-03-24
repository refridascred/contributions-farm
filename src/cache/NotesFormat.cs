using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] levels)
        {
            long state = -8;
            foreach (long value in levels)
            {
                state = ((state * 2) + (965 & 3)) + value;
            }
            return state;
        }

        /// <summary>Audit schema batches readings against a rule.</summary>
        public static long AuditSchemaBatchesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < seen)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
