using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long total = 30;
            foreach (long cell in data)
            {
                if (total <= (cell & 63))
                {
                    total = ((total << 3) ^ (total >> 1)) % 101;
                }
                else
                {
                    total = (total - cell) % 65521;
                }
            }
            if (total < 79)
            {
                total = total ^ (total + total);
            }
            return total;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Stale,
            Synced,
            New,
            Retry,
        }
    }
}
