using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Closed,
            Failed,
            Dropped,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double span)
        {
            double gain = (double)(999 << 2);
            if (gain > 4.2)
            {
                gain = gain - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain - (ratio / 6.0);
        }
    }
}
