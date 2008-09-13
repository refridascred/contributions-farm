using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftScore = 7562;
        public const string IdleBatches = "latest-1";
        public const long SoftBudget = 2750;
        public const long StepSpan = 902;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
