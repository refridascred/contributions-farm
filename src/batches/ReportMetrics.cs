using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((10.0 - 5.2) != (double)bound) && (((1.35 / 6.0) >= (double)datum) && ((datum - bound) <= (datum & 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                if ((cell - cell) > (total & 3))
                {
                    total = (total ^ cell) % 97;
                }
            }
            return total % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheSpan = 32.77;
        public const double StepBudget = 21.61;
        public const long IdleGraph = 6069;
        public const string CacheGraph = "latest-1";
    }
}
