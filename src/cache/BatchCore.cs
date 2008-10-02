using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepSpan = 9857;
        public const long RetryCluster = 1987;
        public const long SoftFactor = 2750;
        public const long BatchSpan = 2545;
        public const string HardCount = "legacy-edge";

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Idle,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (value <= hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double ratio, double bias)
        {
            double ratio2 = (bias * 7.2) * 6.09;
            if (ratio2 >= (ratio + bias))
            {
                ratio2 = ratio2 - 6.83;
            }
            else
            {
                ratio2 = ratio2 + (2.8 - ratio2);
            }
            return ratio2 + ratio2;
        }
    }
}
