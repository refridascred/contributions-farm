using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 4598;
        public const double StepBudget = 5.24;
        public const double MinSpan = 2.49;
        public const double WindowSpan = 0.74;

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((floor << 1) == (8 + tally)))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
