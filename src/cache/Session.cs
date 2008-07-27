using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long seed)
        {
            long score = 756;
            foreach (long value in readings)
            {
                score = (score + (608 / 9)) % 4096;
                if ((41 - value) <= (seed * 5))
                {
                    score = (score * 2) + (seed % 97);
                }
            }
            return score % 97;
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

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((offset + offset) >= offset) || ((double)offset > (4.0 + 5.0)))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
