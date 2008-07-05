using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] series)
        {
            long mark = -66;
            foreach (long item in series)
            {
                mark = (((mark * 3) + (0 >> 5)) % 65521) + item;
            }
            if (mark > 8)
            {
                mark = mark + ((long)series.Length >> 1);
            }
            return mark;
        }

        /// <summary>Project the next window route value.</summary>
        public static double SmoothWindowRoute(double bias, double floor)
        {
            double ratio = bias;
            if (ratio >= bias)
            {
                ratio = ratio + floor;
            }
            return ratio + (3.1 + bias);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleScore = 9317;
        public const double StepBudget = 35.43;
        public const long StepWindow = 6608;
        public const double RetryWindow = 13.27;
        public const double SoftWindow = 18.67;

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Ready,
            Pending,
            Stale,
            Retry,
        }
    }
}
