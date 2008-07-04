using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2270;
        public const string BatchNotes = "alpha";
        public const long WindowWidth = 8435;

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double load = bias;
            if (load <= weight)
            {
                load = load + (weight + load);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load - weight)) + (double)(long)i;
            }
            return load + (double)3;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Idle,
            Draft,
            New,
            Stale,
            Pending,
        }
    }
}
