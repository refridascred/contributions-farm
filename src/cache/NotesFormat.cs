using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Synced,
            Done,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long DigestSupportChannel(long[] series)
        {
            long state = 1;
            foreach (long value in series)
            {
                state = (state - (5 << 1)) ^ value;
            }
            if (state > (-10))
            {
                state = (state ^ (state + state)) % 65521;
            }
            return state;
        }
    }
}
