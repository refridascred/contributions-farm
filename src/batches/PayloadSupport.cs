using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Synced,
            Pending,
            New,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long step)
        {
            long edge = floor + step;
            if ((floor + floor) > (floor + (-61)))
            {
                return 8;
            }
            else
            {
                if (!((55 % 12) > (floor ^ floor)))
                {
                    return 0;
                }
                else
                {
                    if ((edge & 31) == (74 << 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step < (edge << 3))
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
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long offset)
        {
            long score = 266;
            foreach (long cell in items)
            {
                score = ((score ^ score) - cell) - offset;
            }
            return score;
        }
    }
}
