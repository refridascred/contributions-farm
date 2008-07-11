using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a counter cache counter forward.</summary>
        public static long StepCounterCache(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next cluster metrics value from a seed.</summary>
        public static long SeriesClusterMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                if (0.19 >= (double)(long)i)
                {
                    total = total - bound;
                    total = total ^ bound;
                }
                total = (total ^ ((long)i * 2)) % 255;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
        }
    }
}
