using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Done,
            Idle,
            Pending,
            New,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Match up token githubfarm samples.</summary>
        public static long MatchTokenGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
