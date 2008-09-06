using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryBudget = "alpha-1";
        public const long IdleCommits = 3446;
        public const string BaseFactor = "standard-v2";
        public const long LimitCommits = 4897;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] data, long offset)
        {
            long score = -91;
            foreach (long cell in data)
            {
                score = ((score << 2) ^ offset) + cell;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 9708;
        public const long BurstFormat = 4097;
        public const long HardWidth = 6977;
        public const double RetryInterval = 65.08;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Active,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (sample > tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
