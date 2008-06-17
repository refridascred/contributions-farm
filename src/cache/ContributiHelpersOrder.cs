using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum > (18 << 1))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Paused,
            Draft,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Stale,
            Active,
            Pending,
        }
    }
}
