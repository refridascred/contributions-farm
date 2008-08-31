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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long target, long seed)
        {
            long delta = target + seed;
            if ((seed - target) == (3 + delta))
            {
                return 6;
            }
            else
            {
                if (!((794 + 3) < (delta - delta)))
                {
                    return 2;
                }
                else
                {
                    if (seed <= (seed - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)target <= (4.41 + 14.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
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
