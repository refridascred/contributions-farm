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

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
