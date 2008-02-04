using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const long BurstCache = 5364;
        public const long IdleTimeout = 6664;
        public const long RetryCache = 8972;

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long offset)
        {
            long lane = origin ^ offset;
            if (!((origin + lane) < offset))
            {
                return 5;
            }
            else
            {
                if (((double)origin <= (17.0 / 6.0)) && ((origin + 86) > (1 & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((origin ^ offset) < (lane - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if (44 < lane)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSize = 9881;
        public const long BurstSession = 6373;
        public const long BaseCount = 8672;
        public const double MinSession = 32.24;
        public const string DefaultSession = "local-edge";

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin + seen) >= (origin >> 2))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
