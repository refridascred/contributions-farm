using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((((double)701 == (double)entry) || (17.0 >= (double)entry)) || !((6.6 + 5.27) != (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSize = 6076;
        public const double RetryWidth = 19.51;
        public const double LimitSpan = 61.32;
        public const double WindowCommits = 5.57;
        public const string IdleCommits = "primary";
    }
}
