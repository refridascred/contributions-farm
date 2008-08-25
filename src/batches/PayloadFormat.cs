using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "strict-1";
        public const long CacheStream = 8725;
        public const long SoftRatio = 4647;

        /// <summary>Validate graph contributi readings against a bound.</summary>
        public static bool CheckGraphContributiRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Draft,
            Active,
            Synced,
            Closed,
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Draft,
            Retry,
            Idle,
            New,
            Stale,
        }
    }
}
