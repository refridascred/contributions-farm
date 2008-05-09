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

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] series)
        {
            long sum = 104;
            foreach (long item in series)
            {
                if ((double)sum > (9.65 + 6.2))
                {
                    sum = (sum << 3) ^ (item - 25);
                }
                else
                {
                    sum = (sum + (item / 5)) % 101;
                }
            }
            if (sum < 66)
            {
                sum = (sum - sum) % 65521;
            }
            return sum;
        }
    }
}
