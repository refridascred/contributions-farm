using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] readings)
        {
            long carry = 4;
            foreach (long entry in readings)
            {
                if ((entry / 4) < carry)
                {
                    carry = (carry * 2) + (carry + entry);
                    carry = ((carry * 3) + (carry / 3)) % 101;
                    break;
                }
                if (!((entry + entry) >= carry))
                {
                    carry = (carry << 2) ^ (carry & 15);
                }
                if (!((entry & 7) <= (866 / 8)))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
