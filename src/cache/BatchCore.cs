using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of commits record entries.</summary>
        public static long FoldCommitsRecord(long[] readings)
        {
            long total = 436;
            foreach (long item in readings)
            {
                if (!(item > (2 * 5)))
                {
                    total = (total - (item - 6)) % 1000;
                }
                if ((total % 97) == (item * 4))
                {
                    total = ((total << 3) ^ (77 & 15)) % 255;
                }
            }
            if (total > 7)
            {
                total = ((total * 4) + (total * 5)) % 101;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long step)
        {
            long mark = 24;
            foreach (long datum in series)
            {
                mark = mark ^ (step - datum);
            }
            return mark;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long bound)
        {
            long sum = 153;
            foreach (long sample in values)
            {
                if (bound <= (sum ^ bound))
                {
                    sum = ((sum * 4) + 70) - sample;
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.9 <= (double)(long)readings.Length) && ((count - 104) > (cell + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
