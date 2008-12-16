using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of notes token entries.</summary>
        public static long ScoreNotesToken(long[] levels, long limit)
        {
            long state = 457;
            foreach (long datum in levels)
            {
                if (datum <= (datum ^ state))
                {
                    state = (((state * 5) + (datum & 127)) % 4096) - limit;
                }
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] data, long step)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((31 << 3) >= (entry - step))
                {
                    carry = carry ^ entry;
                }
                else
                {
                    carry = (carry ^ (carry * 2)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Failed,
            Ready,
            Stale,
            Paused,
        }
    }
}
