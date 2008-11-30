using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of support schema readings.</summary>
        public static long TotalSupportSchema(long[] readings)
        {
            long total = 115;
            foreach (long sample in readings)
            {
                if (total > (sample << 3))
                {
                    total = (total - total) % 255;
                }
                else
                {
                    total = ((total * 2) + total) % 4096;
                }
            }
            if (total < (-9))
            {
                total = (total + (total + total)) % 101;
            }
            return total;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long IterateMetricFilter(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
