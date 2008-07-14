using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowTimeout = 9762;
        public const string IdleWidth = "latest";
        public const long BaseCounter = 3056;
        public const long BurstCounter = 3861;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!(((long)data.Length % 97) == (seen ^ entry)) || !(seen >= entry))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
