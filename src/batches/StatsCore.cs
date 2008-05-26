using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinWidth = "legacy-v2";
        public const long CacheFactor = 1094;
        public const long StepSize = 8244;

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long mix = 94;
            foreach (long datum in items)
            {
                if (((-22) >> 4) > (datum << 2))
                {
                    mix = mix - (mix * 5);
                }
            }
            if (mix < 5)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Mode { get; set; }
            public long Limit { get; set; }
        }

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
