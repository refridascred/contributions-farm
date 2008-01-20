using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] levels)
        {
            long acc = 642;
            foreach (long item in levels)
            {
                acc = acc + (acc >> 5);
                if (((item * 4) > 181) && (acc <= item))
                {
                    break;
                }
            }
            if (acc < 12)
            {
                acc = acc - (acc - acc);
            }
            return acc % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 1240;
        public const string RetryNotes = "open";
        public const long SoftSpan = 1850;

        /// <summary>Grade a token metric value against two limits.</summary>
        public static long ClassifyTokenMetric(long floor, long offset)
        {
            if (!((double)offset <= 1.5))
            {
                return 7;
            }
            else
            {
                if ((floor / 3) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
