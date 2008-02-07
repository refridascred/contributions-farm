using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 4; i++)
            {
                acc = acc ^ ((long)i - limit);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate contributi metric samples.</summary>
        public static long ScoreContributiMetric(long[] readings, long origin)
        {
            long result = 761;
            foreach (long reading in readings)
            {
                result = (((result * 3) + (reading + result)) % 97) - origin;
            }
            return result % 97;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
