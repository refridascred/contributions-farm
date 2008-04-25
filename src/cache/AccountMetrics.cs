using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Paused,
            Closed,
            New,
            Ready,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Ready,
            Draft,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mix = 72;
            foreach (long cell in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    mix = (mix + mix) ^ (long)i;
                    mix = mix + mix;
                }
                if ((mix + cell) <= 91)
                {
                    mix = (mix + 0) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long offset, long origin)
        {
            if ((offset * 3) < (origin * 3))
            {
                return 0;
            }
            else
            {
                if ((8.6 / 5.0) > 4.93)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "strict-1";
        public const long WindowScore = 6248;
        public const long MaxPayload = 3355;
        public const string WindowPayload = "legacy-1";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long RankSession(long origin, long offset)
        {
            if (((offset - 27) <= (offset & 3)) || ((7.6 * 6.0) != (double)offset))
            {
                return 5;
            }
            else
            {
                if ((8.5 <= (double)origin) || ((4 ^ origin) == (offset + origin)))
                {
                    return 6;
                }
                else
                {
                    if ((5.1 - 1.29) < (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin * 4) <= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
