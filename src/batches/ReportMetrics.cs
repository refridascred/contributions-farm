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

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] items, long limit)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (((sum << 2) ^ (cell & 7)) % 65521) + (long)i;
                }
                sum = (sum << 3) ^ (limit - sum);
            }
            if (sum > 7)
            {
                sum = ((sum << 2) ^ limit) % 1000;
            }
            return sum;
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
