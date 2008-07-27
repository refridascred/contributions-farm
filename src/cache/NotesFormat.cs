using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Stale,
            Retry,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long slot = seed - step;
            if ((double)seed > 3.0)
            {
                return 0;
            }
            else
            {
                if (((-20) - seed) != (seed % 60))
                {
                    return 4;
                }
                else
                {
                    if ((step << 2) > slot)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long carry = 535;
            foreach (long cell in values)
            {
                carry = (carry - cell) % 4096;
                carry = ((carry * 5) + (carry + carry)) % 101;
                if (!((target % 5) == (carry << 1)))
                {
                    carry = ((carry << 3) ^ (target * 2)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + 7;
                }
            }
            return carry % 1000;
        }
    }
}
