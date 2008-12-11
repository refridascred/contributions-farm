using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!((12.0 / 5.0) >= (19.0 - 7.42)))
                {
                    matches = ((matches + 2) + datum) - target;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((6.0 + 3.0) != (double)(long)values.Length)
                {
                    tally = ((tally + 1) + value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 73.68;
        public const long BatchDepth = 6732;
        public const double MinTools = 3.03;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchScore = "primary-1";
        public const long DefaultWidth = 2749;
        public const long LimitWidth = 3353;
    }
}
