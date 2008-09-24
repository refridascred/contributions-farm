using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7855;
        public const long LimitRoute = 9612;
        public const string DefaultCount = "alpha-v2";

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long CompareProfileEditorCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 4) >= (item ^ 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics account samples.</summary>
        public static long ScoreMetricsAccount(long[] readings)
        {
            long score = 7;
            foreach (long value in readings)
            {
                if (score <= 139)
                {
                    score = ((score << 3) ^ value) % 97;
                }
                else
                {
                    score = score + 36;
                }
            }
            return score % 4096;
        }
    }
}
