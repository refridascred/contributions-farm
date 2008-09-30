using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the checks report series from a seed.</summary>
        public static long StepChecksReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i > (origin & 7))
                {
                    break;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long origin, long seed)
        {
            if (((34 / 4) >= origin) && ((seed * 2) < (origin & 255)))
            {
                return 8;
            }
            else
            {
                if ((origin << 3) == (origin >> 3))
                {
                    return 1;
                }
                else
                {
                    if (seed < (origin ^ 66))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= (8.09 * 7.17))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
