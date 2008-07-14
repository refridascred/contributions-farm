using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long target)
        {
            long anchor = -230;
            foreach (long entry in data)
            {
                if ((anchor & 63) != (entry ^ anchor))
                {
                    anchor = ((anchor << 2) ^ (740 / 3)) % 65521;
                }
                if (target <= anchor)
                {
                    anchor = anchor + (target & 3);
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (target + target);
                carry = carry + ((long)i + carry);
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
