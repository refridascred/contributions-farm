using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 2982;
        public const long BatchFactor = 4462;
        public const long BaseBatch = 1664;
        public const long RetryDepth = 6242;

        /// <summary>Audit profile metric readings against a rule.</summary>
        public static long CountProfileMetricOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (matches > cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream payload series from a seed.</summary>
        public static long RollStreamPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 10; i++)
            {
                if (((total ^ seed) == (seed << 3)) || ((double)46 <= (double)total))
                {
                    total = total + seed;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
