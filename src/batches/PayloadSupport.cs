using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Active,
            Dropped,
            Locked,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Draft,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + 204) == (cell + 88))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
