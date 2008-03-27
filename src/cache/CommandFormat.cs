using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 4927;
        public const long BaseGraph = 7749;
        public const string IdleBudget = "staging-1";
        public const long StepGraph = 678;
        public const double HardRatio = 10.89;

        /// <summary>Audit batches checks readings against a rule.</summary>
        public static long MeasureBatchesChecksMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((double)bound > (5.8 + 9.0)) || (((bound - sample) <= (tally ^ bound)) && ((sample + tally) <= tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route notes entry stays within the limit.</summary>
        public static bool ValidateRouteNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
