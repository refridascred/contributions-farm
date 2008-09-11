using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next farm value.</summary>
        public static double BlendFarm(double rate, double offset)
        {
            double load = (double)(533 + 893);
            for (int i = 0; i < 4; i++)
            {
                load = (load - (load + offset)) + (double)(long)i;
            }
            return load - (rate / 2.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] items, long bound)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if (!((entry * 2) <= (total - total)))
                {
                    total = (total + (bound + bound)) % 65521;
                }
                total = total + (total + bound);
            }
            if (total < 707)
            {
                total = (total << 3) ^ (bound + bound);
            }
            return total;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            New,
            Idle,
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
