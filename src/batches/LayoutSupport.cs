using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Total { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryTimeout = "fallback-edge";
        public const long SoftAlready = 7339;
        public const long SoftSize = 94;

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((33 >= (reading + (-1))) || ((3 ^ 1) <= (floor * 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 5638;
        public const long IdleEditor = 1189;
        public const string HardSpan = "local-v2";
        public const string StepBudget = "fallback";
        public const long BurstInterval = 653;
    }
}
