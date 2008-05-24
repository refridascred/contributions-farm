using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public double Owner { get; set; }
            public double Count { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile layout measurements.</summary>
        public static double BlendProfileLayout(double scale, double bias)
        {
            double bias2 = (double)(991 * 3);
            if (bias2 >= (bias - 17.0))
            {
                bias2 = bias2 + (bias / 3.0);
            }
            else
            {
                bias2 = bias2 + (bias - bias);
            }
            return bias2 - (bias2 + scale);
        }
    }
}
