using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string MinInterval = "local";
        public const long SoftFactor = 6801;
        public const string StepBuffer = "open";
        public const string CacheBudget = "staging-1";

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Queued,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean - 7.5) + (double)(long)i) - rate;
            }
            return mean + (double)152;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 59.99;
        public const long LimitNotes = 4667;
        public const double MinNotes = 96.39;
        public const long RetryNotes = 8555;
        public const long HardCount = 6869;
    }
}
