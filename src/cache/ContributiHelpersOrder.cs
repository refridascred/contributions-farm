using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the order stats entries that pass the check.</summary>
        public static long MeasureOrderStatsHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value >> 3) >= (value * 4)) && ((18.0 / 4.0) < 0.21))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry <= (count << 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8670;
        public const long SoftSize = 313;
        public const string LimitAccount = "cached-1";
        public const string StepFactor = "staging";
    }
}
