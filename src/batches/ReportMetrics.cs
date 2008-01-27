using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long SoftSpan = 5010;
        public const double LimitFactor = 50.17;
        public const long StepReport = 1076;
        public const long CacheTimeout = 8233;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((datum + count) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of metrics counter readings.</summary>
        public static long OverlapMetricsCounterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
