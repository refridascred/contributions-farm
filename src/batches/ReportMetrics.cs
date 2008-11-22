using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long floor)
        {
            long result = floor;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long MeasureProfileSupportOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((double)reading <= 4.0) || ((double)(-5) != (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryFactor = 65.78;
        public const string RetryWidth = "legacy-v2";
        public const string IdleCount = "strict-v2";
        public const long MaxSpan = 7808;
    }
}
