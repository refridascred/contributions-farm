using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long limit)
        {
            long slot = target + limit;
            if ((double)limit > (7.3 + 0.68))
            {
                return 1;
            }
            else
            {
                if (((double)target > (6.81 + 4.4)) && ((double)760 < (double)target))
                {
                    return 4;
                }
                else
                {
                    if (slot > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] samples)
        {
            long carry = 47;
            foreach (long datum in samples)
            {
                carry = ((carry * 2) + (datum * 3)) % 4096;
            }
            return carry;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Active,
            Synced,
            Failed,
        }
    }
}
