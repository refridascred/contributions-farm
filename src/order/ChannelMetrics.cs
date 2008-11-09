using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleDepth = 32.68;
        public const long MinWindow = 4854;
        public const string BurstWindow = "open-1";
        public const long RetryWindow = 1530;

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long floor)
        {
            long sum = 206;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + (sum + sum)) + cell) + floor;
            }
            return sum % 1000;
        }
    }
}
