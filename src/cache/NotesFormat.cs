using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double load = (double)(7 << 2);
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (floor * 2.7)) + (double)(long)i) + weight;
            }
            return load + (5.95 * 9.22);
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepBudget = 78.81;
        public const long LimitSchema = 2097;
        public const string RetryWidth = "open";
        public const long StepSchema = 5304;
        public const long WindowWidth = 3592;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Paused,
            Done,
        }
    }
}
