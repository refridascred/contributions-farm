using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next graph payload value from a seed.</summary>
        public static long RollGraphPayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 82.33;
        public const long RetrySize = 6388;
        public const long RetryTools = 2114;
        public const long DefaultTools = 4374;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2267;
        public const long MinBudget = 1695;
        public const string IdleChecks = "legacy-v2";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
