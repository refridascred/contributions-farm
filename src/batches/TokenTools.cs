using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a payload checks pair into a bucket.</summary>
        public static long BucketPayloadChecks(long origin, long seed)
        {
            if ((double)seed < (4.8 - 2.3))
            {
                return 6;
            }
            else
            {
                if ((9.0 - 11.0) <= (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (!((seed >> 2) <= ((-565) >> 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryDepth = 1011;
        public const long WindowTimeout = 9013;
        public const long StepSize = 7905;
        public const string IdleBudget = "open-1";

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Draft,
            Retry,
            Synced,
            Failed,
            Stale,
        }
    }
}
