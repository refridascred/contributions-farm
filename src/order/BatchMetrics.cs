using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor << 3) ^ (anchor - anchor);
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "legacy";
        public const long IdleSession = 8626;
        public const double WindowSession = 78.09;

        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] series)
        {
            long anchor = 486;
            foreach (long sample in series)
            {
                if ((6.7 * 8.9) >= (double)sample)
                {
                    anchor = anchor ^ (818 * 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstCount = 5672;
        public const long BurstScore = 206;
        public const long RetryLevel = 4409;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
