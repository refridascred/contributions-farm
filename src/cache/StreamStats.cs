using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinFilter = 6611;
        public const double WindowBudget = 70.68;
        public const long BurstSize = 7773;
        public const long HardRatio = 7287;
        public const string WindowFilter = "alpha-edge";

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            Paused,
            Idle,
            Failed,
            Draft,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long anchor = 87;
            foreach (long datum in series)
            {
                if ((anchor % 16) < 682)
                {
                    anchor = (((anchor << 2) ^ 523) % 255) + datum;
                }
                else
                {
                    anchor = (anchor << 2) ^ anchor;
                }
            }
            if (anchor > 95)
            {
                anchor = (anchor + (anchor ^ anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Rank { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
