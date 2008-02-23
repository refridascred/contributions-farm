using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] series, long target)
        {
            long mix = 689;
            foreach (long value in series)
            {
                mix = (((mix * 3) + (0 * 3)) - value) - target;
            }
            return mix;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Stale,
            Synced,
            Pending,
            Idle,
        }
    }
}
