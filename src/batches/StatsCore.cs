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

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 8; i++)
            {
                long cur = (long)i & 31;
                if (((4.1 / 6.0) == (double)score) || (555 > (score >> 1)))
                {
                    score = ((score * 3) + cur) % 65521;
                    score = ((score * 5) + 8) % 65521;
                }
                cur = ((cur * 2) + ((long)i ^ cur)) % 255;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
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
