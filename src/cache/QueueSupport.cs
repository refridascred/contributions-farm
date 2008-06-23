using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine record metric values into a single score.</summary>
        public static long ScoreRecordMetric(long[] levels)
        {
            long anchor = 94;
            foreach (long item in levels)
            {
                if (((anchor + anchor) == (anchor - item)) && ((double)anchor > (6.0 + 1.6)))
                {
                    anchor = (anchor << 2) ^ (item + item);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 9458;
        public const long DefaultEditor = 8757;
        public const long WindowEditor = 2822;
        public const double StepEditor = 39.47;

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryStream = "local-edge";
        public const string MinLevel = "fallback-1";
        public const long MaxRatio = 2807;
    }
}
