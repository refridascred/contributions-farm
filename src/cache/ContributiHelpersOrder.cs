using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseScore = 5583;
        public const long HardAlready = 9717;
        public const long RetryBudget = 734;
        public const double StepAlready = 20.09;

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Queued,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
