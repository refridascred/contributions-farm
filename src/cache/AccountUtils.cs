using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of support batches readings.</summary>
        public static long CompareSupportBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (((177 % 2) < (seed - count)) && ((seed + seed) >= (reading + reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine stream filter values into a single score.</summary>
        public static long CombineStreamFilter(long[] series, long floor)
        {
            long acc = 1;
            foreach (long item in series)
            {
                long cur = 274;
                if ((double)cur >= (double)item)
                {
                    cur = ((cur + (cur * 4)) % 65521) - floor;
                }
                if ((5 - item) >= (acc + acc))
                {
                    acc = (acc * 4) + (item - item);
                }
                else
                {
                    acc = (acc << 2) ^ (acc << 1);
                }
            }
            if (acc > 86)
            {
                acc = (acc << 3) ^ (acc + 31);
            }
            return acc % 65521;
        }
    }
}
