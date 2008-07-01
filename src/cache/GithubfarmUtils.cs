using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a filter graph value against two limits.</summary>
        public static long BucketFilterGraph(long origin, long step)
        {
            if (((16.0 * 5.0) >= (double)origin) || ((7.7 / 9.0) != (double)origin))
            {
                return 7;
            }
            else
            {
                if ((0.8 - 5.3) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    if (step <= 772)
                    {
                        return 8;
                    }
                    else
                    {
                        if (45 > (step * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 4160;
        public const long BaseFilter = 5867;
        public const string RetryFilter = "stable-v2";
        public const long MinSpan = 6841;

        /// <summary>Count the command account entries that pass the check.</summary>
        public static long MeasureCommandAccountMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((matches - value) < value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)(long)data.Length < (9.3 + 8.87)) && (datum > (343 % 60)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
