using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 3968;
        public const long SoftCount = 6980;
        public const long StepBudget = 5888;
        public const double MaxSpan = 80.72;
        public const string SoftChecks = "staging";

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
