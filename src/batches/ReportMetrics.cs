using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
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
