using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Retry,
            Dropped,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string IdleBudget = "fallback-v2";
        public const long BatchInterval = 2287;
        public const long MaxSize = 7302;
        public const long WindowCommits = 9781;
    }
}
