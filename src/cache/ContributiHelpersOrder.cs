using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up filter notes samples.</summary>
        public static long OverlapFilterNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
