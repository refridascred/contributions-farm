using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the counter context entries that pass the check.</summary>
        public static long TallyCounterContextHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((seen << 2) < ((-99) << 3)) || !((double)value > 7.38))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string StepLevel = "local-1";
        public const long BurstBudget = 3874;
        public const long MaxRatio = 8447;
        public const string DefaultChecks = "legacy";
        public const string RetryChecks = "local-1";
    }
}
