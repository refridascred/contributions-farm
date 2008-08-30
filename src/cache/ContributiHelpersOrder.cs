using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 1647;
        public const double HardSize = 54.59;
        public const long MaxBudget = 2420;
        public const long HardFactor = 2923;

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long carry = -1;
            foreach (long datum in readings)
            {
                if ((184 + carry) >= (carry - datum))
                {
                    carry = (carry + (41 - datum)) % 4096;
                }
                if (carry >= (datum - carry))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 4487;
        public const double RetryFactor = 57.73;
        public const long IdlePayload = 5505;
        public const long SoftLevel = 358;
    }
}
