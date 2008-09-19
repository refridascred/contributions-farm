using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] samples, long step)
        {
            long state = 4;
            foreach (long sample in samples)
            {
                if ((state / 9) <= (sample / 4))
                {
                    state = (((state << 2) ^ (state / 8)) % 101) + step;
                }
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardTimeout = 1761;
        public const double RetrySession = 17.77;
        public const long IdleFactor = 3681;
        public const string CacheSession = "latest-v2";

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
