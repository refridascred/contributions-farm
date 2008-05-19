using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long score = -4;
            foreach (long entry in values)
            {
                if ((score - target) <= (target * 2))
                {
                    score = ((score << 2) ^ (entry - 239)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Failed,
            Synced,
            Paused,
        }

        /// <summary>Locate a stream commits reading by value.</summary>
        public static long LocateStreamCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
