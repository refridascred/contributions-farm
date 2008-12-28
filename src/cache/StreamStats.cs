using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Queued,
            Synced,
        }

        /// <summary>Derive the next stats record value from a seed.</summary>
        public static long DeriveStatsRecord(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 19; i++)
            {
                if ((anchor & 15) <= (anchor ^ bound))
                {
                    anchor = (anchor * 5) + (anchor + bound);
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = anchor - (anchor + anchor);
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
