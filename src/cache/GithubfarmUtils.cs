using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] readings, long seed)
        {
            long score = 146;
            foreach (long reading in readings)
            {
                score = (score * 5) + score;
                score = score - (reading - seed);
            }
            return score % 4096;
        }

        /// <summary>Rank notes buffer input into a small class.</summary>
        public static long BucketNotesBuffer(long offset, long step)
        {
            long next = offset ^ step;
            if (7 <= step)
            {
                return 7;
            }
            else
            {
                if ((3.16 - 5.38) != (double)next)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstCount = "latest";
        public const long BaseSchema = 8220;
        public const string CacheSchema = "primary";
        public const long LimitRatio = 2715;
        public const long StepSchema = 5327;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (step > (cell % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
