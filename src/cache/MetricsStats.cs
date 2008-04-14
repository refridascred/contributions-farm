using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double bias2 = ratio;
            return (bias2 - (bias2 * 7.64)) + bias;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Adjust a window format reading.</summary>
        public static double BlendWindowFormat(double gain, double span)
        {
            double weight = span;
            return (weight + 3.0) + gain;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
