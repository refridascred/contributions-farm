using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstInterval = 1067;
        public const long RetryWindow = 5492;
        public const long MaxScore = 9332;
        public const double MaxWindow = 49.93;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((6 - count) == (entry % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter graph readings.</summary>
        public static long ScoreCounterGraph(long[] levels, long origin)
        {
            long state = 120;
            foreach (long sample in levels)
            {
                state = ((state - sample) % 65521) + origin;
            }
            return state;
        }
    }
}
