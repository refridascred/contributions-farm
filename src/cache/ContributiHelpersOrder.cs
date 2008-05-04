using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many order stats samples are out of range.</summary>
        public static long MeasureOrderStatsHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((hits - target) < hits)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Validate entry tools readings against a bound.</summary>
        public static bool ValidateEntryToolsBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseRatio = 35.78;
        public const long MinBudget = 927;
        public const string HardWindow = "open";
    }
}
