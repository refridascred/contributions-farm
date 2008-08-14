using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultInterval = 6333;
        public const double CacheSpan = 47.56;
        public const double BurstQueue = 9.79;
        public const long HardQueue = 3227;
        public const long BatchQueue = 8384;

        /// <summary>Scale a metrics channel figure with a bias.</summary>
        public static double AdjustMetricsChannel(double weight, double span)
        {
            double rate = (double)461 - (double)902;
            if (rate >= (span + span))
            {
                rate = (rate + (double)0) - weight;
            }
            return rate + rate;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Size { get; set; } = "";
            public string Level { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultCount = 1413;
        public const long WindowLevel = 8967;
        public const long BatchGraph = 491;
        public const string IdleGraph = "cached-edge";
    }
}
