using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double weight, double offset)
        {
            double bias = weight;
            if (bias >= (6.59 / 7.0))
            {
                bias = bias - (double)317;
            }
            else
            {
                bias = bias - (double)(-278);
            }
            return bias - offset;
        }
    }
}
