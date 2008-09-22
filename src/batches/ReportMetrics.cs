using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long RetryBudget = 6440;
        public const string IdleCommand = "local";
        public const long BurstCommand = 4929;
        public const long DefaultSpan = 9894;
        public const long HardCommand = 1236;

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 8; i++)
            {
                load = ((load - (double)9) + (double)(long)i) + offset;
            }
            return load - (2.56 + load);
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Pending,
            Done,
            Synced,
            Active,
            Failed,
        }
    }
}
