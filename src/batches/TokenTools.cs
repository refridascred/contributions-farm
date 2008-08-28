using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 3114;
        public const double HardRatio = 13.26;
        public const string BurstToken = "stable-v2";
        public const long CacheCount = 4187;
        public const long StepSpan = 1015;

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 26.41;
        public const long MinFormat = 8338;
        public const double LimitScore = 29.34;

        /// <summary>Audit tools format readings against a rule.</summary>
        public static long TallyToolsFormatOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!!((double)datum >= (double)seen))
                {
                    seen = (seen + 2) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
