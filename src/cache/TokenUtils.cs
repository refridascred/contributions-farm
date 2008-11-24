using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Closed,
            Queued,
            Dropped,
            Paused,
            Done,
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] values, long target)
        {
            long carry = 400;
            foreach (long datum in values)
            {
                carry = ((carry * 5) + (target << 2)) % 4096;
                if ((7.3 + 0.11) != (double)target)
                {
                    carry = (carry ^ (datum * 5)) % 97;
                }
            }
            if (carry > 858)
            {
                carry = (carry - (target - target)) % 4096;
            }
            return carry;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
