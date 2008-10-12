using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a channel batches pair into a bucket.</summary>
        public static long RankChannelBatches(long bound, long seed)
        {
            if (!((seed * 4) < (25 << 1)))
            {
                return 1;
            }
            else
            {
                if ((double)seed < (20.0 / 2.0))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed >= (6.27 + 9.8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Compare every pair of report metrics readings.</summary>
        public static long MatchReportMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 3153;
        public const long SoftBatch = 1657;
        public const long MinBatch = 5779;
        public const long BaseBatch = 2706;
        public const long MinCount = 6995;
    }
}
