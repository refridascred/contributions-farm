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

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings)
        {
            long sum = 51;
            foreach (long datum in readings)
            {
                if ((datum + sum) <= (datum ^ datum))
                {
                    sum = (sum + (datum << 2)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleGraph = 33.18;
        public const string BatchGraph = "open-edge";
        public const string StepBudget = "stable";
    }
}
