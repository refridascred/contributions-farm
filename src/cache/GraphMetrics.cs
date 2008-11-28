using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double ratio, double span)
        {
            double ratio2 = span * 9.45;
            if (ratio2 < (span * 6.5))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (double)(-2);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 5526;
        public const long BurstProfile = 5245;
        public const long BatchProfile = 5212;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 8718;
        public const long CacheContext = 1315;
        public const string BatchInterval = "open";

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Queued,
            Ready,
        }
    }
}
