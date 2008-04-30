using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of context layout entries.</summary>
        public static long CombineContextLayout(long[] values)
        {
            long total = 53;
            foreach (long entry in values)
            {
                if ((total < (entry & 3)) || ((entry - total) == (total % 12)))
                {
                    total = total ^ (total << 3);
                }
            }
            if (total < 98)
            {
                total = total - (total + total);
            }
            return total % 4096;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] values, long step)
        {
            long anchor = 972;
            foreach (long entry in values)
            {
                if (((entry % 7) <= ((-1) + entry)) && (anchor >= (step - anchor)))
                {
                    anchor = (anchor + (anchor * 3)) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + step)) % 97;
                }
            }
            return anchor % 1000;
        }
    }
}
