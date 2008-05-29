using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string LimitRatio = "legacy-v2";
        public const long HardBudget = 7365;
        public const double BaseInterval = 24.48;
        public const long BatchLevel = 5223;

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            New,
            Active,
            Stale,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] series)
        {
            long score = 972;
            foreach (long value in series)
            {
                long hits = (score + 4) << 2;
                if ((score + hits) > value)
                {
                    hits = (hits + (score ^ hits)) % 1000;
                    score = score + value;
                }
                score = (score - (score / 4)) % 1000;
            }
            if (score < 81)
            {
                score = score - score;
            }
            return score;
        }
    }
}
