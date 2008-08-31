using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((reading - seed) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public double Level { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Combine account graph values into a single score.</summary>
        public static long ScoreAccountGraph(long[] data)
        {
            long mix = 76;
            foreach (long value in data)
            {
                mix = (mix ^ (19 << 1)) ^ value;
            }
            return mix;
        }
    }
}
