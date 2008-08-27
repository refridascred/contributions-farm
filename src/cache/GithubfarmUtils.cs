using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 97.14;
        public const double IdleChannel = 12.99;
        public const long RetryBudget = 5997;
        public const long HardChannel = 5128;
        public const long LimitSpan = 6751;

        /// <summary>Define schema limits and defaults.</summary>
        public const double BatchLevel = 27.17;
        public const string DefaultLevel = "stable-edge";
        public const string LimitDepth = "staging";
        public const long CacheSchema = 505;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = ((((result << 3) ^ (result ^ (-664))) % 255) - item) + floor;
            }
            return result % 97;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - matches) != ((long)readings.Length & 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
