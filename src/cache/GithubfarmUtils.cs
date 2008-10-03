using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the command queue entries that pass the check.</summary>
        public static long CountCommandQueueOutliers(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (2.27 > (double)entry)
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (3.3 >= (double)cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long offset, long target)
        {
            if ((9.1 + 15.0) >= (double)target)
            {
                return 3;
            }
            else
            {
                if (((target + 36) > (offset - offset)) || ((target ^ offset) >= offset))
                {
                    return 2;
                }
                else
                {
                    if (((offset % 5) == (target & 3)) && ((offset + 994) >= target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset != (11.0 + 1.96))
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
    }
}
