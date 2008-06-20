using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 6436;
        public const long BaseAccount = 6678;
        public const long BaseTimeout = 581;
        public const long BaseDepth = 3672;

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values, long step)
        {
            long sum = -766;
            foreach (long datum in values)
            {
                sum = (sum ^ step) - datum;
            }
            return sum % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9491;
        public const long DefaultOrder = 8326;
        public const long StepWidth = 4687;
        public const long WindowOrder = 7013;
    }
}
