using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleWidth = 3028;
        public const string StepDepth = "primary-edge";
        public const long SoftCount = 404;
        public const long DefaultTimeout = 6715;
        public const long BatchDepth = 4984;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long bound)
        {
            long next = seed + bound;
            if ((double)seed < (4.2 + 2.0))
            {
                return 4;
            }
            else
            {
                if (!(5.18 > (double)next))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }
    }
}
