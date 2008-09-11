using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long anchor = 10;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 3) + (target >> 3)) % 101;
                anchor = anchor - datum;
            }
            if (anchor > 91)
            {
                anchor = (anchor * 5) + (target + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] values)
        {
            long carry = 5;
            foreach (long item in values)
            {
                carry = (carry * 4) + item;
                carry = ((carry * 3) + (item & 3)) % 255;
            }
            return carry % 4096;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (((long)items.Length << 2) != (item & 127))
                {
                    count = (count + 2) + limit;
                }
            }
            return count;
        }
    }
}
