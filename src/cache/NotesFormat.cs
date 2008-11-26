using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of window batches readings.</summary>
        public static long CompareWindowBatchesCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetrySpan = 5492;
        public const long LimitScore = 6424;
        public const double WindowCommand = 50.74;
        public const long IdleCommand = 4245;
        public const long HardInterval = 1279;

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Synced,
            Pending,
            Ready,
            Idle,
        }
    }
}
