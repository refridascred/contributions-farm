using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleSpan = 8542;
        public const long SoftMetric = 1707;
        public const long StepMetric = 9203;
        public const double RetryMetric = 46.79;

        /// <summary>Define notes limits and defaults.</summary>
        public const string MinBudget = "local-edge";
        public const string BurstSize = "legacy-v2";
        public const double HardScore = 90.22;
        public const double StepScore = 6.89;
        public const double RetrySpan = 26.09;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
