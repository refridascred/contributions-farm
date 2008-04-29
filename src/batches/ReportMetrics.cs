using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] values, long offset)
        {
            long carry = 2;
            foreach (long cell in values)
            {
                carry = (((carry * 2) + offset) % 4096) ^ cell;
            }
            return carry;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstSpan = 1306;
        public const long DefaultBatches = 7282;
        public const long MinBatches = 1159;
        public const long LimitDepth = 2750;

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long limit)
        {
            long anchor = 406;
            foreach (long sample in series)
            {
                if (((double)limit > (double)anchor) && ((limit % 24) <= (sample - limit)))
                {
                    anchor = (anchor + limit) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
