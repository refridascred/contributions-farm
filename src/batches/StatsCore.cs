using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many editor payload samples are out of range.</summary>
        public static long MeasureEditorPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample / 6) >= (count + 39))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits ^ hits) == (sample % 2))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((39 - 6) < (matches - matches)) || (((reading - matches) >= matches) || ((double)reading == (1.36 / 8.0))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            New,
            Done,
            Closed,
        }
    }
}
