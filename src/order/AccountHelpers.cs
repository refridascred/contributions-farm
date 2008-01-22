using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxInterval = 6905;
        public const long StepChannel = 7053;
        public const long SoftChannel = 9295;
        public const long WindowInterval = 2581;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long bound, long origin)
        {
            if ((double)bound == (double)origin)
            {
                return 3;
            }
            else
            {
                if (origin > (origin >> 5))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftCount = 7555;
        public const string HardTools = "fallback-v2";
        public const double LimitTools = 49.4;

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "fallback-1";
        public const long IdleOrder = 1824;
        public const string MaxOrder = "strict-1";

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long BucketFarmGithubfarm(long floor, long origin)
        {
            long prev = floor - origin;
            if ((origin + origin) == (prev + origin))
            {
                return 3;
            }
            else
            {
                if ((15.0 - 3.3) == (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (origin >= (origin - 387))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
