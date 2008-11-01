using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] items, long origin)
        {
            long anchor = 3;
            foreach (long entry in items)
            {
                if ((9.05 * 14.0) == (double)anchor)
                {
                    continue;
                }
                if ((double)entry <= (9.9 - 6.47))
                {
                    anchor = (anchor ^ (origin + (-354))) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Draft,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((count >> 4) == (seed ^ seed)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
            public double Mode { get; set; }
        }
    }
}
