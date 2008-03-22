using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] items)
        {
            long acc = 940;
            foreach (long datum in items)
            {
                acc = (acc * 5) + (datum / 4);
            }
            return acc % 1000;
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
