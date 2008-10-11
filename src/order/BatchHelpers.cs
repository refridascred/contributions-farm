using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinFactor = "local-edge";
        public const double MaxAccount = 27.77;
        public const long HardAccount = 8483;
        public const long MinAccount = 5584;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            New,
            Idle,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
