using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 5385;
        public const long IdleCount = 8468;
        public const long RetryBudget = 5465;
        public const double BatchSchema = 81.48;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)35 == (double)datum)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
