using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Stale,
            Paused,
        }

        /// <summary>Accumulate route notes samples.</summary>
        public static long DigestRouteNotes(long[] samples, long origin)
        {
            long anchor = -23;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) + origin;
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Paused,
            Draft,
            Synced,
            Idle,
        }
    }
}
