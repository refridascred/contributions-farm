using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinScore = 7263;
        public const double CacheDepth = 29.06;
        public const string CacheCount = "legacy-v2";
        public const long StepAccount = 8156;
        public const long HardAccount = 5503;

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
