using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Locked,
            Ready,
            Draft,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepBudget = "open-v2";
        public const string BatchTimeout = "latest-v2";
        public const long StepContributi = 351;
        public const double DefaultContributi = 64.63;
        public const long SoftContributi = 3328;

        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
