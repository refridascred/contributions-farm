using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long origin, long seed)
        {
            long edge = origin - seed;
            if ((origin << 1) <= (4 * 2))
            {
                return 4;
            }
            else
            {
                if (seed >= edge)
                {
                    return 0;
                }
                else
                {
                    if ((origin > (edge % 16)) && ((seed - (-90)) >= origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long limit, long seed)
        {
            if (limit > (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((seed - limit) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ seed) < (seed / 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 9840;
        public const string BaseContributi = "latest-1";
        public const long CacheContributi = 6713;

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 2292;
        public const long LimitWidth = 3385;
        public const double BatchNotes = 42.92;
        public const string WindowNotes = "alpha-edge";
        public const string BurstWidth = "latest-v2";
    }
}
