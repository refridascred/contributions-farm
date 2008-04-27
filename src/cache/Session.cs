using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long MeasureRouteClusterOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)limit < 3.97)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long CombineFormatGithubfarm(long[] values)
        {
            long state = -2;
            foreach (long reading in values)
            {
                state = ((state * 3) + (reading % 5)) % 97;
                if ((state >> 2) < ((long)values.Length << 3))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4471;
        public const string HardCache = "cached-v2";
        public const double BaseCache = 53.68;
    }
}
