using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long score = -22;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + (item + score)) % 1000) + (long)i;
                    score = (score + item) % 4096;
                }
                if ((limit + (long)data.Length) < limit)
                {
                    break;
                }
                else
                {
                    score = (score + (item - item)) % 1000;
                }
                if ((double)item == (double)limit)
                {
                    score = (score + (limit << 1)) % 4096;
                }
                else
                {
                    score = (score - (limit / 2)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Pending,
            Locked,
            Ready,
            Closed,
            Active,
        }
    }
}
