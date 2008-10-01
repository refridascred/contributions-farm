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

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data)
        {
            long anchor = 75;
            foreach (long item in data)
            {
                if ((item ^ item) <= 22)
                {
                    anchor = ((anchor << 3) ^ (anchor % 10)) % 255;
                }
                else
                {
                    anchor = anchor ^ (anchor << 3);
                }
                if (4 < (anchor + item))
                {
                    break;
                }
            }
            return anchor % 1000;
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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
