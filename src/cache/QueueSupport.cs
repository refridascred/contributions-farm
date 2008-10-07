using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 6927;
        public const long HardChecks = 107;
        public const long BaseLevel = 6729;
        public const long RetryChecks = 5009;
        public const double MaxLevel = 25.98;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Closed,
            Paused,
            Done,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
