using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 20; i++)
            {
                long prev = sum;
                if (((long)i + limit) <= prev)
                {
                    prev = prev + (limit / 4);
                    sum = (sum * 4) + limit;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Active,
            Pending,
        }
    }
}
