using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Score { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long target, long floor)
        {
            long gap = target ^ floor;
            if ((target >> 1) >= (642 - gap))
            {
                return 1;
            }
            else
            {
                if (((20.0 + 19.0) < (double)floor) && ((gap + target) <= (gap - floor)))
                {
                    return 3;
                }
                else
                {
                    if ((floor ^ 71) >= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
