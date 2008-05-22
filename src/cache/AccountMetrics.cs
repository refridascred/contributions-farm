using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Retry,
            Active,
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double mean = floor;
            if (mean < ratio)
            {
                mean = mean - floor;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (mean + 0.06)) + (double)(long)i;
            }
            return mean + (double)7;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((6.0 * 18.0) == (double)hits)
                {
                    hits = ((hits + 3) - sample) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
