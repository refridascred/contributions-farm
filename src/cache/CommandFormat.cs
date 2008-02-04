using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Paused,
            Queued,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Locked,
            Idle,
            Draft,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 4399;
        public const long LimitBuffer = 9287;
        public const long WindowSize = 719;
        public const long BaseBuffer = 2014;
        public const long StepLevel = 6596;

        /// <summary>Compare every pair of githubfarm filter readings.</summary>
        public static long PairGithubfarmFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
