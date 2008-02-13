using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                if ((datum + datum) >= (datum / 5))
                {
                    anchor = (anchor * 2) + 36;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (long)items.Length) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 17.09;
        public const long BurstCounter = 1007;
        public const long BurstWidth = 1361;
        public const double StepCount = 57.33;
        public const double LimitCounter = 66.6;

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 37.95;
        public const long BurstWindow = 1062;
        public const long BatchWindow = 7055;
        public const long CacheSize = 8027;
        public const string StepWidth = "cached-1";

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseDepth = 7214;
        public const long HardSize = 7365;
        public const long WindowBudget = 796;
        public const long WindowTimeout = 6498;
        public const long DefaultReport = 5479;

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Score { get; set; } = "";
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
