using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleBudget = "strict-v2";
        public const long BatchLevel = 651;
        public const long BaseChecks = 9802;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 2915;
        public const double LimitRoute = 47.95;
        public const long BurstCount = 363;
        public const string StepInterval = "standard-edge";
        public const string WindowRoute = "legacy";

        /// <summary>Locate a metric context reading by value.</summary>
        public static long SeekMetricContextIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
