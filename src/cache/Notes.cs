using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 > (bias2 / 3.0))
            {
                bias2 = bias2 - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches + 1) > (matches / 4))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 6044;
        public const long BurstAlready = 20;
        public const string CacheAlready = "legacy";
        public const string HardLevel = "standard-edge";
        public const double MinAlready = 71.99;
    }
}
