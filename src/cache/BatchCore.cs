using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of order checks readings.</summary>
        public static long WeighOrderChecks(long[] items)
        {
            long carry = 9;
            foreach (long item in items)
            {
                if (!((502 + carry) <= item))
                {
                    carry = (carry << 3) ^ (carry + item);
                }
                else
                {
                    carry = (carry - (item + carry)) % 1000;
                }
            }
            if (carry > 473)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values)
        {
            long state = 94;
            foreach (long value in values)
            {
                if (((value << 3) == (state - state)) || ((double)state < (double)62))
                {
                    state = ((state << 2) ^ state) % 1000;
                }
            }
            if (state > 65)
            {
                state = (state << 3) ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Synced,
            Closed,
        }
    }
}
