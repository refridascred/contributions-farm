using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleTimeout = 42.92;
        public const double WindowChecks = 59.97;
        public const long BurstTimeout = 7523;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 5700;
        public const long SoftGithubfarm = 7928;
        public const string BatchGithubfarm = "standard-1";
        public const long HardGithubfarm = 5796;
        public const double StepBudget = 40.06;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mark = 440;
            foreach (long item in items)
            {
                mark = ((mark + (mark + mark)) % 97) - item;
            }
            if (mark < 70)
            {
                mark = ((mark * 4) + (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
