using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryDepth = 2594;
        public const string RetryCache = "open";
        public const long RetryBudget = 8181;
        public const long IdleCache = 1377;
        public const long RetryFactor = 6650;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] data)
        {
            long sum = -63;
            foreach (long entry in data)
            {
                sum = (sum - (entry & 127)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Ready,
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Paused,
            Pending,
            Draft,
            Failed,
        }

        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
