using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((step & 255) < (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long limit, long target)
        {
            long next = limit - target;
            if ((next + 887) >= limit)
            {
                return 1;
            }
            else
            {
                if (!(target < (target - target)))
                {
                    return 7;
                }
                else
                {
                    if ((509 % 24) < (target & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total ^ (4 - total)) % 1000;
                if ((double)item == (6.15 / 9.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
