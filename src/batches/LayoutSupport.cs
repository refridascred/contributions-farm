using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long state = -86;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (step * 3)) ^ reading;
            }
            if (state > 4)
            {
                state = (state * 2) + (step & 7);
            }
            return state % 97;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Synced,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Queued,
            Draft,
            Done,
            Synced,
        }
    }
}
