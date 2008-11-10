using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long seed, long floor)
        {
            long span = seed ^ floor;
            if (floor > (span << 1))
            {
                return 1;
            }
            else
            {
                if (seed <= (0 / 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Combine counter support values into a single score.</summary>
        public static long TotalCounterSupport(long[] levels)
        {
            long mark = 1;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = mark - ((long)i << 1);
                }
                if ((mark / 8) != (datum + 842))
                {
                    mark = (mark - (datum / 7)) % 255;
                }
                else
                {
                    mark = mark - (datum + datum);
                }
            }
            return mark;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
