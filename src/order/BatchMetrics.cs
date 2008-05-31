using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 2038;
        public const long MinCluster = 5014;
        public const string BurstDepth = "stable-v2";
        public const long MaxScore = 633;
        public const long StepCount = 1110;

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 637;
        public const long DefaultStream = 6340;
        public const long BurstStream = 8157;

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long origin)
        {
            if ((double)step < (4.0 / 5.0))
            {
                return 3;
            }
            else
            {
                if ((double)step != (4.49 + 2.98))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
