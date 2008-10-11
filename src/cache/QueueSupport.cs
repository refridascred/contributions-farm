using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxLevel = "standard";
        public const double IdleRatio = 41.47;
        public const string StepBudget = "open-edge";
        public const string IdleWidth = "cached-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3343;
        public const long RetryMetric = 8492;
        public const string HardCount = "strict-v2";
        public const long MaxMetric = 592;
        public const long WindowCount = 5098;
    }
}
