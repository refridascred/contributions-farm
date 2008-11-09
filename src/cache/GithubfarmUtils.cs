using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MinSpan = "strict-edge";
        public const string WindowProfile = "standard-v2";
        public const long MinWidth = 5699;
        public const long MinFactor = 6;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long seed)
        {
            if (origin < (origin + seed))
            {
                return 4;
            }
            else
            {
                if ((11.0 - 1.7) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long bound)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = ((mark - (sample - sample)) % 101) - bound;
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
