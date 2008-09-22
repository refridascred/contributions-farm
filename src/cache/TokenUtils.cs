using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseTimeout = 6391;
        public const double LimitSchema = 46.25;
        public const string CacheSchema = "local-1";

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long anchor = 3;
            foreach (long sample in levels)
            {
                anchor = ((anchor ^ (anchor % 100)) % 101) ^ sample;
            }
            if (anchor < (-44))
            {
                anchor = (anchor << 2) ^ (anchor + anchor);
            }
            return anchor % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitDepth = 52.93;
        public const string DefaultFactor = "cached-v2";
        public const long RetrySchema = 4540;
    }
}
