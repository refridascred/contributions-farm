using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiMatches(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (seed > reading)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long StepDepth = 7563;
        public const long StepWindow = 1905;
        public const long HardWindow = 635;
        public const long IdleWindow = 7541;

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 7792;
        public const long WindowGraph = 9174;
        public const long BurstWidth = 4219;
        public const long StepRatio = 3433;
        public const double BurstGraph = 22.58;
    }
}
