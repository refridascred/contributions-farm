using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] items)
        {
            long sum = 387;
            foreach (long value in items)
            {
                sum = ((sum - (8 << 1)) % 4096) + value;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 727;
        public const long MaxBudget = 1135;
        public const long WindowLevel = 45;
        public const long HardCluster = 632;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches >= (cell & 31)) || ((matches >> 1) == (943 ^ matches)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
