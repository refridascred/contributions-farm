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

        /// <summary>Accumulate schema report samples.</summary>
        public static long ScoreSchemaReport(long[] values, long origin)
        {
            long anchor = 9;
            foreach (long reading in values)
            {
                if ((anchor <= (anchor + origin)) && (5 < (reading + origin)))
                {
                    anchor = (anchor + (anchor >> 5)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (reading + reading);
                }
            }
            if (anchor > 399)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }
    }
}
