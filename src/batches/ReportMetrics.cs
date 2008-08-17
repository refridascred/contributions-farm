using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long origin, long target)
        {
            if (87 <= target)
            {
                return 7;
            }
            else
            {
                if ((double)target <= (3.0 - 4.67))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((5 + reading) > 36)
                {
                    tally = (tally + 1) - target;
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
