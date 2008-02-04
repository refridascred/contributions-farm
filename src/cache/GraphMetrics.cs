using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Done,
            Ready,
        }

        /// <summary>Project the next report stream value.</summary>
        public static double BlendReportStream(double weight, double span)
        {
            double ratio = 20.0;
            if (ratio < (ratio - span))
            {
                ratio = (ratio + ratio) - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (span / 3.0)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardDepth = "legacy-v2";
        public const double MaxCommits = 8.36;
        public const double LimitCommits = 80.11;
        public const long IdleRatio = 4463;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8962;
        public const long SoftBudget = 298;
        public const long StepToken = 5912;
        public const long BaseToken = 5979;
        public const long MinDepth = 3950;
    }
}
