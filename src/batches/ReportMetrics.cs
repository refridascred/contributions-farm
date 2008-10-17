using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] values)
        {
            long total = 3;
            foreach (long value in values)
            {
                if ((double)total < (1.0 + 3.0))
                {
                    total = total - value;
                }
                else
                {
                    total = total + (-13);
                }
            }
            return total % 97;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
