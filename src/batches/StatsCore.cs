using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long anchor = 213;
            foreach (long cell in readings)
            {
                anchor = ((anchor ^ (anchor * 5)) % 65521) - cell;
            }
            if (anchor > 2)
            {
                anchor = (anchor - (anchor ^ 76)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first order metrics entry that matches the target.</summary>
        public static long FindOrderMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string DefaultCounter = "stable-1";
        public const long LimitCounter = 7659;
        public const long RetryWidth = 2489;
        public const long SoftBudget = 8699;
        public const double BaseCounter = 14.89;

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
