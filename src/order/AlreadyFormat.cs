using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Paused,
            Closed,
            Stale,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 12.23;
        public const string IdleContributi = "legacy-edge";
        public const long StepBudget = 9363;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 732;
        public const long BurstLevel = 9240;
        public const string StepCount = "staging-1";
        public const string MaxWidth = "standard-v2";

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
