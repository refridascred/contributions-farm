using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((7.0 + 8.0) < (double)sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits / 9) > (entry * 3))
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 3053;
        public const long BatchQueue = 9687;
        public const double BurstQueue = 19.8;
        public const long IdleBudget = 1817;
    }
}
