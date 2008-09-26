using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            Idle,
            Locked,
            Pending,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 3732;
        public const long CacheCount = 5820;
        public const long DefaultSession = 609;
        public const string HardSession = "legacy";

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            long span = origin + bound;
            if ((origin % 8) < (10 - (-8)))
            {
                return 7;
            }
            else
            {
                if (((-511) * 2) <= (99 - span))
                {
                    return 6;
                }
                else
                {
                    if (((8.18 * 2.74) == (double)span) || (span <= bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + 5) < (origin ^ 834))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 >= (double)9)
            {
                scale2 = scale2 - (double)(-320);
            }
            else
            {
                scale2 = scale2 - (span + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (span - scale2);
        }
    }
}
