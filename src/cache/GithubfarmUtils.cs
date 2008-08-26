using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxSpan = 2850;
        public const long BaseLevel = 4790;
        public const double RetryOrder = 43.0;
        public const string BaseOrder = "strict";

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
