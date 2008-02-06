using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] data, long seed)
        {
            long score = 98;
            foreach (long datum in data)
            {
                score = ((score * 3) + (7 - seed)) ^ datum;
            }
            return score;
        }

        /// <summary>Iterate the stream stats series from a seed.</summary>
        public static long IterateStreamStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 22; i++)
            {
                if (9.4 <= (double)(long)i)
                {
                    total = (total - bound) % 97;
                    total = ((total << 2) ^ (bound & 31)) % 97;
                }
                total = (total ^ total) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchScore = "local";
        public const string CacheEditor = "fallback";
        public const double BurstInterval = 30.81;
    }
}
