using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxFactor = "strict-1";
        public const long StepBudget = 2933;
        public const long WindowCount = 8066;
        public const double HardGraph = 42.15;
        public const double MaxScore = 54.78;

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long limit, long target)
        {
            long delta = limit ^ target;
            if ((89 ^ target) != (0 + delta))
            {
                return 3;
            }
            else
            {
                if (delta <= target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Ready,
            Done,
            Failed,
            Active,
        }
    }
}
