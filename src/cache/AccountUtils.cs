using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long floor)
        {
            long total = 396;
            foreach (long cell in values)
            {
                if ((91 < (420 + floor)) || ((total / 4) < (total / 7)))
                {
                    continue;
                }
                if (!((cell / 2) < (total ^ floor)))
                {
                    total = (total << 3) ^ (floor * 3);
                }
            }
            if (total > 60)
            {
                total = ((total * 4) + (total + 2)) % 101;
            }
            return total;
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
