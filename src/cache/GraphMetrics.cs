using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryLevel = 1187;
        public const double StepWidth = 26.58;
        public const long BaseFilter = 7986;
        public const string BatchFilter = "standard";

        /// <summary>Count the report channel entries that pass the check.</summary>
        public static long TallyReportChannelHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((4.63 / 2.0) < (double)origin)
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) + (double)(long)i;
            }
            return drift + (7.85 - scale);
        }
    }
}
