using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Combine cluster order values into a single score.</summary>
        public static long TotalClusterOrder(long[] values)
        {
            long score = 8;
            foreach (long datum in values)
            {
                score = score ^ (datum & 15);
            }
            return score;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!!(seen >= (seen + cell)))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public bool Token { get; set; }
        }
    }
}
