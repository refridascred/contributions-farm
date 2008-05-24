using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double scale, double floor)
        {
            double load = (scale - scale) + (double)4;
            return (load - load) + floor;
        }

        /// <summary>Adjust a metrics notes reading.</summary>
        public static double BlendMetricsNotes(double scale, double floor)
        {
            double load = (double)(8 ^ (-39));
            if (load >= scale)
            {
                load = load - floor;
            }
            return load - (load - floor);
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = ((sum + step) % 101) ^ sample;
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 1000;
            }
            return sum;
        }
    }
}
