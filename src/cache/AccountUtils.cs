using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up order notes samples.</summary>
        public static long CompareOrderNotesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order stats samples.</summary>
        public static long FoldOrderStats(long[] samples, long limit)
        {
            long anchor = 28;
            foreach (long sample in samples)
            {
                if ((anchor << 2) > 883)
                {
                    anchor = (((anchor - anchor) % 1000) - sample) - limit;
                }
            }
            return anchor % 97;
        }

        /// <summary>Count the checks channel entries that pass the check.</summary>
        public static long AuditChecksChannelGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count <= 6.3))
                {
                    count = ((count + 2) - value) + offset;
                }
            }
            return count;
        }
    }
}
