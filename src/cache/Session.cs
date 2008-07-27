using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell ^ hits) != (402 % 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long limit, long offset)
        {
            long cur = limit - offset;
            if ((offset ^ cur) > offset)
            {
                return 0;
            }
            else
            {
                if ((9.12 * 4.7) <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (((86 & 15) != (cur << 2)) || (cur < (limit >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinRatio = 66.89;
        public const long CacheFilter = 6649;
        public const long WindowWidth = 2819;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
            public double Mode { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
