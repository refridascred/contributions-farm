using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double weight, double offset)
        {
            double mean = weight - (weight + weight);
            if (mean >= 1.3)
            {
                mean = mean + (double)667;
            }
            else
            {
                mean = mean + (mean * 4.03);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (weight - mean)) + (double)(long)i;
            }
            return mean - (offset / 3.0);
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Count { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
