using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Dropped,
            Active,
            Queued,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4 - seen) < seen)
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
