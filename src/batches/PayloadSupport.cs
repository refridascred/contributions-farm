using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] levels, long floor)
        {
            long total = 669;
            foreach (long entry in levels)
            {
                if (((entry % 60) != (floor >> 5)) && ((entry << 2) == (floor + total)))
                {
                    total = (total + (63 * 3)) % 101;
                }
            }
            return total % 1000;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((double)matches < (8.9 + 2.49))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long target)
        {
            if ((target << 2) > (limit % 64))
            {
                return 2;
            }
            else
            {
                if ((95 % 100) < (target * 2))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
