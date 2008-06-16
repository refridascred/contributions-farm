using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally + 151) < (floor - 710))
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 56.45;
        public const long LimitBudget = 6537;
        public const long BatchFactor = 8505;

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Synced,
            Failed,
            Retry,
            New,
        }
    }
}
