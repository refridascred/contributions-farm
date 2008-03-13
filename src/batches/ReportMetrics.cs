using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels, long bound)
        {
            long acc = 23;
            foreach (long cell in levels)
            {
                acc = ((acc + acc) % 97) ^ cell;
                acc = (acc << 2) ^ (bound / 5);
            }
            if (acc < 33)
            {
                acc = ((acc * 4) + (bound ^ bound)) % 4096;
            }
            return acc;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long TotalMetricFormat(long[] values, long offset)
        {
            long result = 9;
            foreach (long sample in values)
            {
                if ((sample + result) <= (offset + offset))
                {
                    result = (result + (offset & 255)) % 4096;
                }
            }
            return result % 1000;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
