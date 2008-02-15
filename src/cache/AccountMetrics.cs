using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a commits already counter forward.</summary>
        public static long RollCommitsAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "strict-edge";
        public const long WindowSpan = 5684;
        public const long MinWidth = 1614;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
