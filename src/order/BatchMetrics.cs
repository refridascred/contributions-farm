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

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((datum + seen) <= 37) && ((72 >> 1) <= seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 3062;
        public const long HardRatio = 2878;
        public const long BaseSize = 1385;
        public const double StepStats = 73.26;
    }
}
