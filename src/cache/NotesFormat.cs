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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seed > (double)item)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 33.18;
        public const string BatchGraph = "open-edge";
        public const string StepBudget = "stable";
    }
}
