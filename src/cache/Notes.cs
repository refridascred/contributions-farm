using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Derive the next format cluster value from a seed.</summary>
        public static long StepFormatCluster(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (origin + origin)) % 97;
                score = (score * 5) + ((long)i * 5);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ProjectCounter(double weight, double floor)
        {
            double weight2 = 6.36;
            return weight2 + (floor - weight);
        }

        /// <summary>Find the first cache window entry that matches the target.</summary>
        public static long FindCacheWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
