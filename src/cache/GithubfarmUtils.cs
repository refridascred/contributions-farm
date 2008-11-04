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

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long origin)
        {
            if ((57 * 4) < origin)
            {
                return 7;
            }
            else
            {
                if ((origin % 5) != (floor * 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
