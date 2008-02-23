using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double DefaultCount = 65.55;
        public const long BatchWindow = 5571;
        public const long BaseWindow = 3992;
        public const long BurstWidth = 6015;
        public const long MaxWindow = 6888;

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
