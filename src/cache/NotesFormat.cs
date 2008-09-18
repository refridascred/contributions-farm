using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Retry,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Draft,
            New,
            Locked,
            Idle,
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
