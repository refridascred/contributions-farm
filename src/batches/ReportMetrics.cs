using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate filter channel samples.</summary>
        public static long WeighFilterChannel(long[] items)
        {
            long total = 415;
            foreach (long item in items)
            {
                if ((item ^ total) <= (item + total))
                {
                    total = (total - (item ^ total)) % 255;
                }
                else
                {
                    total = total ^ total;
                }
                if ((item >> 4) < item)
                {
                    break;
                }
            }
            if (total < 208)
            {
                total = total + (total + total);
            }
            return total;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits + hits) < (hits * 5))
                {
                    hits = (hits + 1) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long target, long origin)
        {
            if ((origin >> 2) > target)
            {
                return 1;
            }
            else
            {
                if ((target * 3) > (767 & 1))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
