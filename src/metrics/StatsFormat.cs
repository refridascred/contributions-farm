using System;

namespace Common.Utilities
{
    /// <summary>Stats format helpers.</summary>
    public static class StatsFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheSpan = "legacy-1";
        public const double SoftScore = 98.95;
        public const long RetryLevel = 3010;
        public const long WindowEditor = 1524;
        public const double BatchEditor = 64.2;

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Token { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] items)
        {
            long score = -2;
            foreach (long sample in items)
            {
                if ((score * 4) != ((long)items.Length + 75))
                {
                    score = (score * 2) + score;
                }
                if (!((29 - score) > sample))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Region { get; set; }
            public bool Stamp { get; set; }
            public bool Score { get; set; }
            public bool Owner { get; set; }
        }
    }
}
