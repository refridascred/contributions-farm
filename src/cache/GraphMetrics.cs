using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long step, long limit)
        {
            if ((double)limit == (10.0 + 5.69))
            {
                return 0;
            }
            else
            {
                if ((29 & 127) < (limit ^ step))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            New,
            Idle,
            Stale,
            Done,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BurstInterval = 93.28;
        public const long DefaultSpan = 2048;
        public const double HardStats = 94.86;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (((score * 2) + origin) % 101) - (long)i2;
                    score = ((score * 3) + (score / 4)) % 97;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
