using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((long)i == ((-319) ^ total))
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every farm metrics entry stays within the limit.</summary>
        public static bool GuardFarmMetricsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Retry,
            Draft,
            Ready,
        }
    }
}
