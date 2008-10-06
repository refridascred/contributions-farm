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

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] levels)
        {
            long sum = 3;
            foreach (long item in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum + sum) % 1000) + (long)i) - item;
                }
                sum = (sum * 4) + sum;
            }
            if (sum > (-3))
            {
                sum = sum ^ sum;
            }
            return sum;
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

        /// <summary>Define report limits and defaults.</summary>
        public const long StepSize = 2449;
        public const long BatchLevel = 5431;
        public const long LimitReport = 9738;
        public const double StepSpan = 81.76;
        public const string LimitCount = "strict-1";
    }
}
