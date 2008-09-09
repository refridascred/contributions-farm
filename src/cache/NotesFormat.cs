using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Pending,
            Synced,
            New,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 5880;
        public const long BatchMetrics = 6717;
        public const long HardScore = 8305;
        public const double DefaultMetrics = 59.08;
    }
}
