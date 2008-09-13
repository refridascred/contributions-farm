using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up batch githubfarm samples.</summary>
        public static long OverlapBatchGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCount = 44.74;
        public const long MaxCommits = 1182;
        public const long IdleBudget = 6777;
        public const long IdleSize = 8442;
        public const long WindowCommits = 8648;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
