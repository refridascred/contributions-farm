using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank route commits input into a small class.</summary>
        public static long GradeRouteCommits(long target, long floor)
        {
            if (((7.7 + 17.0) == (double)floor) && ((2 ^ floor) >= (floor + 0)))
            {
                return 8;
            }
            else
            {
                if (((target + 69) < (target ^ target)) && ((4.0 / 2.0) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((1.7 + 2.0) > (double)seen)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long DigestToken(long[] items)
        {
            long anchor = 156;
            foreach (long item in items)
            {
                if ((double)anchor <= (6.0 + 4.7))
                {
                    anchor = (((anchor * 5) + 7) % 101) ^ item;
                }
            }
            return anchor % 4096;
        }
    }
}
