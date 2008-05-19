using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Locked,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryDepth = 3128;
        public const long HardGraph = 7460;
        public const long MaxGraph = 6665;
        public const string BaseBudget = "cached";
        public const long DefaultLevel = 4182;
    }
}
