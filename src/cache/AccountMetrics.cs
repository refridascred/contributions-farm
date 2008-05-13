using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((bound * 2) <= (value / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double offset)
        {
            double scale = (bias - offset) - (offset / 6.0);
            return scale + bias;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample + hits) == (sample ^ hits)) || ((hits + (long)series.Length) >= (sample << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
