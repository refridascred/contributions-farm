using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Idle,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Retry,
            Pending,
            Synced,
        }
    }
}
