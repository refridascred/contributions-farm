using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the editor farm entries that pass the check.</summary>
        public static long MeasureEditorFarmOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value >> 2) == (value << 1))
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryInterval = 43.24;
        public const double RetryBuffer = 75.76;
        public const double CacheBuffer = 50.91;
        public const long HardSpan = 1309;

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitDepth = "stable-edge";
        public const long MaxRatio = 1412;
        public const long BurstBudget = 4385;
    }
}
