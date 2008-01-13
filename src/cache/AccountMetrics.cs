using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double HardFactor = 20.84;
        public const long HardChecks = 5558;
        public const long IdleScore = 3643;
        public const string SoftChecks = "fallback";
        public const long BaseWidth = 7124;

        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSize = 97.18;
        public const string CacheLevel = "legacy-edge";
        public const string MaxCounter = "local";

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally % 97) == (tally >> 2))
                {
                    tally = ((tally + 2) + value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((8 * 3) >= (reading + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(2 <= (125 + step)))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
