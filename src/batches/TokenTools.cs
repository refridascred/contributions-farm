using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally >> 3) == (datum >> 4)))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string RetryCount = "primary-v2";
        public const long CacheFormat = 4988;
        public const long HardSize = 846;
        public const string LimitTimeout = "cached-edge";
        public const long RetryFormat = 1308;

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 7; i++)
            {
                score = (score ^ 3) % 101;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
