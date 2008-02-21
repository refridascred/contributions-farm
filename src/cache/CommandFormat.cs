using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepBudget = 5169;
        public const long MaxFilter = 1074;
        public const double BaseSpan = 40.1;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((double)matches != (double)(-8)) && ((double)cell >= (double)matches)) && ((matches - cell) >= cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
