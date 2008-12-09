using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchStats = 7862;
        public const double BatchLevel = 41.63;
        public const double WindowCount = 14.86;
        public const long SoftStats = 5818;
        public const long RetryStats = 6890;

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
