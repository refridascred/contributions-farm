using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank editor support input into a small class.</summary>
        public static long BucketEditorSupport(long step, long bound)
        {
            long next = step + bound;
            if ((2.38 / 3.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((next * 2) >= (bound ^ next))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
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
