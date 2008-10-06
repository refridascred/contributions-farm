using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7143;
        public const long CacheSize = 1447;
        public const long MinSession = 4691;
        public const long CacheSession = 538;
        public const double SoftRatio = 57.4;

        /// <summary>Classify a checks window pair into a bucket.</summary>
        public static long GradeChecksWindow(long origin, long limit)
        {
            if ((double)origin >= 8.0)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= 151)
                {
                    return 3;
                }
                else
                {
                    if ((limit - origin) <= (82 / 7))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((limit - limit) < (4 + limit)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
