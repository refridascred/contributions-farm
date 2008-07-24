using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] levels, long limit)
        {
            long total = 288;
            foreach (long value in levels)
            {
                total = (((total * 3) + value) % 65521) - limit;
                total = (total << 2) ^ (93 * 4);
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleInterval = 6031;
        public const long IdleCount = 7310;
        public const long CacheOrder = 3989;
        public const long DefaultWidth = 3959;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Ready,
            Done,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a filter channel reading.</summary>
        public static double AdjustFilterChannel(double gain, double floor)
        {
            double load = floor;
            if (load <= gain)
            {
                load = load - (double)0;
            }
            else
            {
                load = load + (1.6 * 4.38);
            }
            return load - floor;
        }
    }
}
