using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data)
        {
            long sum = 7;
            foreach (long cell in data)
            {
                sum = (sum + (sum & 127)) + cell;
            }
            return sum % 1000;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 89.56;
        public const double SoftFactor = 86.9;
        public const long MaxLevel = 1547;
        public const double WindowInterval = 92.74;
        public const double MaxSupport = 18.63;

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 3304;
        public const double DefaultInterval = 54.66;
        public const string BurstRatio = "standard";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public long Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up batch graph samples.</summary>
        public static long PairBatchGraphCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
