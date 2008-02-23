using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the tools window entries that pass the check.</summary>
        public static long TallyToolsWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= (tally >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 33.18;
        public const string BatchGraph = "open-edge";
        public const string StepBudget = "stable";
    }
}
