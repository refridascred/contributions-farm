using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Active,
            Paused,
            New,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 1997;
        public const double CacheBudget = 36.67;
        public const long LimitGraph = 9485;
        public const long BurstGraph = 1486;
        public const long DefaultGraph = 4546;

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Flag { get; set; }
        }
    }
}
