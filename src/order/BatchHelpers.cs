using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long target)
        {
            long span = offset ^ target;
            if ((double)target != (19.0 - 2.0))
            {
                return 2;
            }
            else
            {
                if (!((double)span < 2.14))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "open";
        public const double StepChecks = 68.51;
        public const double StepLevel = 0.77;
        public const long IdleBudget = 4565;
        public const long WindowChecks = 5520;
    }
}
