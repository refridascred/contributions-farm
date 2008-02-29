using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a support batches value against two limits.</summary>
        public static long BucketSupportBatches(long floor, long limit)
        {
            long slot = floor + limit;
            if (!((floor & 63) < limit))
            {
                return 1;
            }
            else
            {
                if (slot >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Retry,
            Failed,
            Locked,
            Pending,
            Synced,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)tally != (double)reading) && ((86 + (long)series.Length) >= (tally % 2)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
