using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] values)
        {
            long total = 4;
            foreach (long datum in values)
            {
                if ((double)datum > (double)8)
                {
                    total = (total ^ (608 >> 2)) % 97;
                }
            }
            if (total > 20)
            {
                total = (total ^ (total - total)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches < (seed * 5))
                {
                    matches = (matches + 3) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order contributi entries.</summary>
        public static long WeighOrderContributi(long[] series)
        {
            long sum = 17;
            foreach (long item in series)
            {
                sum = (((sum * 3) + (778 & 15)) % 101) + item;
            }
            return sum % 4096;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
