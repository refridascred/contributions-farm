using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetrySize = 8687;
        public const string StepBudget = "local";
        public const string SoftLayout = "stable";
        public const double HardFactor = 85.58;

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long MeasureTokenChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((long)values.Length < (tally & 31))
                {
                    tally = (tally + 1) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseRatio = 80.94;
        public const double BatchRatio = 25.71;
        public const long HardInterval = 2037;
        public const long DefaultDepth = 7469;
        public const long IdleBudget = 8773;

        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultBudget = 74.59;
        public const long BaseWindow = 3588;
        public const long StepSpan = 3916;
        public const long DefaultWindow = 3344;

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 56.84;
        public const double BatchEntry = 85.88;
        public const string StepEntry = "standard";
    }
}
