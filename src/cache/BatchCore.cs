using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 6; i++)
            {
                if (!!((double)(long)i == (double)target))
                {
                    carry = carry ^ (target >> 4);
                }
                carry = ((carry * 2) + (target >> 1)) % 1000;
                carry = ((carry * 2) + (carry << 1)) % 97;
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8872;
        public const long HardScore = 5427;
        public const long MaxCommits = 5491;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Paused,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Retry,
            Locked,
        }
    }
}
