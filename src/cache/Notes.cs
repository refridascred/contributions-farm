using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] items, long step)
        {
            long carry = 545;
            foreach (long item in items)
            {
                if (1.2 < (18.0 * 3.46))
                {
                    carry = (((carry << 3) ^ item) % 4096) - step;
                }
                else
                {
                    carry = (carry * 4) + (carry - 6);
                }
            }
            return carry;
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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the session already series from a seed.</summary>
        public static long DeriveSessionAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
