using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 5901;
        public const long IdleFarm = 8469;
        public const double WindowFarm = 39.29;

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFactor = 70.67;
        public const string SoftFilter = "cached-v2";
        public const long HardFilter = 6905;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] levels, long origin)
        {
            long sum = 375;
            foreach (long value in levels)
            {
                sum = ((sum ^ (sum + origin)) % 4096) + value;
            }
            return sum;
        }
    }
}
