using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string MinSpan = "fallback-v2";
        public const long SoftTimeout = 8787;
        public const double BurstScore = 33.51;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = mark - (origin + (long)i);
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((52 % 24) >= (tally + tally))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
