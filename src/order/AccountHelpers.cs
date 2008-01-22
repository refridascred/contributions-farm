using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BatchReport = "stable-1";
        public const string BurstFactor = "legacy-edge";
        public const string WindowWidth = "stable-1";

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

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Failed,
            Ready,
            Done,
            Dropped,
        }

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

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryInterval = 887;
        public const long IdleCache = 6387;
        public const long RetryCache = 2289;
        public const long BatchSize = 1375;
        public const long CacheSpan = 1189;
    }
}
