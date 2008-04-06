using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long bound, long offset)
        {
            if ((30 / 3) <= offset)
            {
                return 3;
            }
            else
            {
                if ((offset >= bound) || (offset < (offset - bound)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "stable-1";
        public const long BurstWidth = 4683;
        public const string LimitCommand = "fallback";
        public const long RetryLevel = 8445;

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "local";
        public const long BurstRatio = 4367;
        public const long CachePayload = 2179;
        public const double DefaultFactor = 13.64;
    }
}
