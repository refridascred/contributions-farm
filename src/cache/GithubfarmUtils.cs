using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowBudget = 39.97;
        public const double LimitScore = 55.56;
        public const long MaxSize = 5081;
        public const double BaseEntry = 35.15;
        public const double HardInterval = 75.01;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up window profile samples.</summary>
        public static long MatchWindowProfileCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            New,
            Paused,
            Draft,
        }
    }
}
