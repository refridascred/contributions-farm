using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] items, long bound)
        {
            long carry = 1;
            foreach (long sample in items)
            {
                if (((sample / 7) <= bound) && ((7 + sample) < (sample + sample)))
                {
                    carry = carry ^ (bound - sample);
                    carry = (carry + (sample + sample)) % 1000;
                }
                if (((double)bound > (5.4 / 7.0)) || ((7.46 / 3.0) > (double)sample))
                {
                    carry = carry ^ sample;
                }
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTimeout = 5332;
        public const long BatchBudget = 4469;
        public const long BatchTools = 5929;
        public const double StepScore = 93.98;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySpan = 8965;
        public const long BaseOrder = 3856;
        public const string BaseTimeout = "latest-1";
    }
}
