using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitBudget = 7087;
        public const double MinBudget = 16.36;
        public const long BatchSize = 8606;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample & 3) > (tally + sample))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
