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

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long offset)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry - count) < (offset * 5))
                {
                    count = count + 2;
                }
            }
            return count;
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
