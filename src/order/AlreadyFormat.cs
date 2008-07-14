using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long sum = 9;
            foreach (long sample in series)
            {
                if (((0.5 + 9.0) == (double)sum) || ((sample - sample) < (sum + sum)))
                {
                    sum = sum ^ (7 << 1);
                }
            }
            if (sum < 96)
            {
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardFactor = 4558;
        public const long DefaultWindow = 4550;
        public const long IdleWindow = 1652;
        public const long BatchWindow = 2818;
        public const string CacheRatio = "standard-1";

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long seed)
        {
            if (((5 & 31) >= floor) && (seed < (floor - floor)))
            {
                return 3;
            }
            else
            {
                if ((double)seed < (0.2 * 3.12))
                {
                    return 4;
                }
                else
                {
                    if (((floor >> 5) == (floor << 3)) && (44 <= (floor / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + floor) != (seed - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long origin, long target)
        {
            long bound = origin - target;
            if (((double)target > 5.5) && ((double)bound < 6.34))
            {
                return 4;
            }
            else
            {
                if (!(origin >= (19 ^ target)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
