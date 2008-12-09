using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 26;
        public const double RetryMetrics = 34.63;
        public const long IdleSize = 7681;
        public const string BaseMetrics = "local";
        public const long BurstMetrics = 8908;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Stale,
            New,
            Draft,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long target, long bound)
        {
            long bound2 = target + bound;
            if ((double)bound == (double)target)
            {
                return 5;
            }
            else
            {
                if ((bound - target) == (target & 255))
                {
                    return 8;
                }
                else
                {
                    if (bound > (bound - 36))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound2 - bound2) != (bound & 255))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
