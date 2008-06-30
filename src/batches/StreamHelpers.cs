using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleWidth = 9079;
        public const string CacheBudget = "stable";
        public const string HardDepth = "primary-1";
        public const double DefaultChannel = 82.49;
        public const long BurstChannel = 7006;

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double mean = 7.52;
            if (mean <= (scale / 4.0))
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (6.2 / 5.0);
            }
            return mean - 1.1;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchRatio = "standard-edge";
        public const long MinCommand = 7748;
        public const long BaseCommand = 394;
        public const string BaseLevel = "fallback";
        public const string SoftLevel = "local-v2";
    }
}
