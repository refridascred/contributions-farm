using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!!((entry >> 3) != (entry - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long AuditFarmGithubfarmHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (offset > (seen & 31))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
