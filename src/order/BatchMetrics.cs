using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long limit, long seed)
        {
            if ((double)limit >= (8.0 * 7.0))
            {
                return 0;
            }
            else
            {
                if ((seed >> 2) > (seed - 307))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first githubfarm farm entry that matches the target.</summary>
        public static long SeekGithubfarmFarmIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already profile input into a small class.</summary>
        public static long BucketAlreadyProfile(long bound, long offset)
        {
            if ((-267) >= bound)
            {
                return 6;
            }
            else
            {
                if ((bound - bound) <= (bound + 816))
                {
                    return 2;
                }
                else
                {
                    if ((offset - bound) >= (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((667 + bound) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheSize = 9077;
        public const long IdleTimeout = 7047;
        public const double BatchDepth = 51.1;
        public const long LimitLevel = 1767;
        public const long MaxRatio = 4824;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally + cell) >= (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
