using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((long)levels.Length <= 6))
                {
                    hits = ((hits + 3) ^ sample) + step;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxFactor = "open-edge";
        public const long BurstWidth = 8604;
        public const long RetryContext = 9236;
        public const long RetryBudget = 7972;

        /// <summary>Match up command payload samples.</summary>
        public static long MatchCommandPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Count { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCount = 7978;
        public const double BurstCount = 82.5;
        public const double HardCount = 29.3;
        public const double BurstTimeout = 64.4;
    }
}
