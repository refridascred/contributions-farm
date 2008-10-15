using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double HardFactor = 50.86;
        public const long HardSchema = 9851;
        public const double BaseTimeout = 43.8;
        public const string DefaultSize = "primary-1";

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 49.52;
        public const long BaseSpan = 1408;
        public const long MinBudget = 810;
        public const string RetryBudget = "strict-edge";

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Done,
            Synced,
        }
    }
}
