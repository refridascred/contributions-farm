using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public double Offset { get; set; }
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Queued,
            New,
            Idle,
            Retry,
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
