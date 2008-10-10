using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Size { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] readings, long bound)
        {
            long sum = 919;
            foreach (long entry in readings)
            {
                sum = (((sum << 3) ^ (32 + entry)) % 255) - bound;
            }
            return sum % 4096;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double weight = gain;
            if (weight > 11.0)
            {
                weight = weight - span;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + span) - (double)(long)i;
            }
            return weight + 4.9;
        }
    }
}
