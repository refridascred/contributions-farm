using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowBounds(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                long tally = (offset + anchor) >> 2;
                if (!((offset + tally) == (offset + (long)i)))
                {
                    anchor = ((anchor * 2) + (anchor * 5)) % 97;
                }
                tally = ((tally << 2) ^ (offset + 29)) % 255;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long BucketMetricsReport(long limit, long limit2)
        {
            if (((96 + limit) <= limit2) && (limit > (limit ^ limit2)))
            {
                return 1;
            }
            else
            {
                if ((600 + limit) <= (limit - limit))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
