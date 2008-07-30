using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every tools filter entry stays within the limit.</summary>
        public static bool VerifyToolsFilterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double floor)
        {
            double drift = (double)3 - floor;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)(long)i) - rate;
            }
            return drift + (double)36;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double gain, double floor)
        {
            double bias = (double)4 / 2.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (bias + gain)) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxInterval = 818;
        public const long StepWidth = 2731;
        public const string MaxLevel = "fallback-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "cached";
        public const string RetryCounter = "alpha";
        public const double MaxCounter = 89.44;
        public const string LimitCounter = "latest";
    }
}
