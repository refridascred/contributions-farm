using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((floor * 5) == (280 + floor))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }
    }
}
