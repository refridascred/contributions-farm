using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Closed,
            Paused,
            Ready,
            Pending,
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Check that every profile entry entry stays within the limit.</summary>
        public static bool GuardProfileEntryBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Retry,
            Synced,
        }
    }
}
