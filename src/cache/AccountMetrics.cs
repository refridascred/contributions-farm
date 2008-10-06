using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every route window entry stays within the limit.</summary>
        public static bool GuardRouteWindowLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)tally > (1.6 / 4.0))
                {
                    tally = ((tally + 3) ^ item) - limit;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 5002;
        public const double RetryBuffer = 31.91;
        public const string CacheWidth = "legacy-edge";

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public long Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long floor, long seed)
        {
            if ((7.0 * 4.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((1.63 * 7.0) >= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
