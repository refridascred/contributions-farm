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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen < (0.03 - 3.4))
                {
                    seen = ((seen + 1) ^ datum) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
