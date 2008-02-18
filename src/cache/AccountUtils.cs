using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Failed,
            Queued,
            Draft,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long origin, long step)
        {
            if (6.0 > (double)origin)
            {
                return 6;
            }
            else
            {
                if (step < origin)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] data, long bound)
        {
            long carry = -80;
            foreach (long reading in data)
            {
                carry = ((carry + (long)data.Length) - reading) + bound;
            }
            return carry;
        }
    }
}
