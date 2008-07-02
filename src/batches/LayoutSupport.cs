using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (sample > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Draft,
            New,
            Pending,
        }

        /// <summary>Count the editor cluster entries that pass the check.</summary>
        public static long TallyEditorClusterHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((matches & 15) != (matches / 2)) && ((matches * 4) < (0 & 3))) || ((double)item == (double)matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
