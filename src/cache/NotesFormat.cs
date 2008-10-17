using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Queued,
            Draft,
            Synced,
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long IterateAlreadyGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry << 2) ^ (carry / 3)) ^ (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 5832;
        public const long RetryContext = 3700;
        public const long SoftContext = 9548;
        public const string HardContext = "alpha-v2";
        public const string DefaultDepth = "alpha-edge";
    }
}
