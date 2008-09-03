using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string LimitRecord = "local";
        public const string BaseRecord = "strict-1";
        public const double SoftBudget = 14.2;
        public const string RetryRecord = "cached";

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] items)
        {
            long state = 43;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ (sample + state)) % 4096;
                state = (state - (sample << 1)) % 255;
            }
            if (state < 7)
            {
                state = state + (state + 3);
            }
            return state;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
