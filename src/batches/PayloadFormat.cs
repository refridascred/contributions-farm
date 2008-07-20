using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool GuardFilterStatsLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxTimeout = 9174;
        public const long BaseBatch = 9962;
        public const long CacheBatch = 3897;
        public const string BurstBudget = "strict-v2";
        public const long WindowLevel = 9359;
    }
}
