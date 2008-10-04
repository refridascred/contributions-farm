using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (!(74 <= (sample / 9)) || ((long)series.Length < (sample << 1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }
    }
}
