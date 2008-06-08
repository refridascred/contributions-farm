using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Dropped,
            Paused,
        }

        /// <summary>Roll a filter metrics counter forward.</summary>
        public static long IterateFilterMetrics(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + ((long)i / 7)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Mode { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
