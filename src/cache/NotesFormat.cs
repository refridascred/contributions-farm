using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < limit)
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Iterate the graph editor series from a seed.</summary>
        public static long SeriesGraphEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = anchor ^ bound;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
