using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route githubfarm series from a seed.</summary>
        public static long RollRouteGithubfarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = sum - sum;
                sum = (sum - offset) % 101;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryLevel = "strict";
        public const long CacheSize = 8479;
        public const long RetryTimeout = 8280;
        public const long MaxFarm = 870;
        public const long IdleFarm = 7039;

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long bound, long offset)
        {
            long lane = bound - offset;
            if ((87 >> 5) < bound)
            {
                return 7;
            }
            else
            {
                if ((offset >= (offset + 8)) && (offset <= (lane << 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
