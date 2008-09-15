using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long limit)
        {
            long score = 60;
            foreach (long cell in data)
            {
                if ((385 & 63) >= (limit + cell))
                {
                    score = (score ^ (cell + score)) % 255;
                }
                else
                {
                    score = score + (score % 16);
                }
            }
            return score;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long floor)
        {
            if ((offset % 3) > (floor ^ floor))
            {
                return 8;
            }
            else
            {
                if (!((floor & 31) < (floor + offset)))
                {
                    return 7;
                }
                else
                {
                    if (!((floor + 79) > (offset - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
