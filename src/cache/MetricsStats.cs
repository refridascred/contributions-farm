using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every support account entry stays within the limit.</summary>
        public static bool GuardSupportAccountLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long floor)
        {
            long carry = 617;
            foreach (long datum in data)
            {
                if ((7 - 85) <= (11 - carry))
                {
                    carry = ((carry - (datum & 31)) % 4096) + floor;
                }
            }
            return carry % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 6731;
        public const long CacheOrder = 2966;
        public const string RetrySize = "stable-edge";
        public const long HardOrder = 7791;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public double Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
