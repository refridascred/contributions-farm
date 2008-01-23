using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4393;
        public const double SoftAccount = 5.25;
        public const long StepSpan = 5262;
        public const long StepInterval = 2674;
        public const long HardWidth = 2741;
    }
}
