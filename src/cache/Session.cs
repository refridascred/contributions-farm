using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 7631;
        public const double HardSupport = 9.58;
        public const long CacheScore = 5894;
        public const long LimitScore = 9803;
        public const string LimitSupport = "primary-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const double CacheSession = 53.79;
        public const double MinSession = 4.18;
        public const double DefaultScore = 17.65;
        public const long RetryBudget = 2038;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
