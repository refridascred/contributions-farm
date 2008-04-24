using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Draft,
            Closed,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] samples)
        {
            long state = -80;
            foreach (long value in samples)
            {
                state = state - (value + state);
            }
            return state % 65521;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Locked,
            Draft,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 32.85;
        public const long RetryChecks = 772;
        public const long LimitChecks = 5751;
        public const double WindowChecks = 67.93;
        public const long HardLevel = 6619;
    }
}
