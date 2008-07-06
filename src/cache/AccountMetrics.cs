using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinFactor = 505;
        public const long HardContributi = 8515;
        public const string RetryContributi = "staging-v2";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 2332;
        public const string HardInterval = "primary-edge";
        public const long BatchSchema = 4009;

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Locked,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry * 4) + (827 - carry);
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
