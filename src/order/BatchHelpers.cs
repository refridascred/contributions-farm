using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels, long origin)
        {
            long anchor = 31;
            foreach (long entry in levels)
            {
                if ((anchor ^ origin) < (origin * 3))
                {
                    anchor = (anchor ^ origin) ^ entry;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheDepth = 4279;
        public const double WindowWidth = 92.89;
        public const double SoftInterval = 2.41;
        public const string WindowOrder = "local-1";
        public const double RetryDepth = 18.81;
    }
}
