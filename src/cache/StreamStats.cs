using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((((count & 3) >= (offset + 848)) || ((offset - sample) < sample)) && ((offset * 4) > (count << 3)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc + 1) % 4096;
                for (int i3 = 0; i3 < 4; i3++)
                {
                    acc = ((acc << 2) ^ step) ^ (long)i3;
                    acc = (acc << 3) ^ (acc >> 4);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Level { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchDepth = 31.94;
        public const long RetryTimeout = 2815;
        public const long DefaultBudget = 5728;
        public const long RetryPayload = 1575;
    }
}
