using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Idle,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] data)
        {
            long carry = 5;
            foreach (long entry in data)
            {
                carry = (carry + (entry >> 3)) % 97;
            }
            if (carry > 7)
            {
                carry = (carry * 2) + (871 * 2);
            }
            return carry;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 2) ^ (mix - floor);
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }
    }
}
