using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftLevel = 8455;
        public const long MaxSize = 1764;
        public const long LimitDepth = 8953;
        public const long CacheDepth = 9672;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 7028;
        public const long CacheScore = 6489;
        public const double BatchRatio = 94.42;
        public const long WindowSize = 2631;
        public const long BatchGraph = 3854;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 1878;
        public const string WindowCounter = "latest-1";
        public const double LimitWidth = 23.83;
        public const long IdleWidth = 6404;

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Scale a metrics stream figure with a bias.</summary>
        public static double BlendMetricsStream(double rate, double span)
        {
            double weight = (double)(893 * 4);
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (rate + span)) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
