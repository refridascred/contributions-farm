using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double StepMetric = 9.11;
        public const long DefaultBudget = 5641;
        public const string BatchMetric = "fallback-v2";
        public const string BatchFactor = "stable";
        public const string BaseMetric = "strict-1";

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] levels, long target)
        {
            long total = 42;
            foreach (long item in levels)
            {
                if ((double)target == (double)6)
                {
                    total = (((total * 2) + target) % 4096) + item;
                }
                if ((target + target) == ((-20) * 3))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
