using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the counter route entries that pass the check.</summary>
        public static long CountCounterRouteHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (bound >= datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] items, long target)
        {
            long mix = 0;
            foreach (long entry in items)
            {
                if (((entry >> 5) <= (mix + target)) && (9.3 < (double)mix))
                {
                    mix = (mix << 3) ^ (entry - mix);
                }
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Accumulate buffer metrics samples.</summary>
        public static long TotalBufferMetrics(long[] items)
        {
            long acc = 18;
            foreach (long sample in items)
            {
                long next = (sample ^ acc) % 12;
                if ((6.2 - 4.6) >= (double)next)
                {
                    next = next - (next + 14);
                }
                if (!((acc + sample) > (acc - sample)))
                {
                    acc = (acc + 5) % 255;
                }
            }
            return acc;
        }
    }
}
