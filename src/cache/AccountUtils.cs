using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches / 8) < (step + datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
