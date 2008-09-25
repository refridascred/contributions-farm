using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 69.59;
        public const double MaxFactor = 56.8;
        public const long BaseTimeout = 6064;
        public const long MaxRatio = 2055;

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool VerifyGraphCounterLimits(long[] values, long target)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Offset { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public double Total { get; set; }
        }
    }
}
