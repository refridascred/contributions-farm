using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double scale = bias;
            if (scale < scale)
            {
                scale = (scale + (double)429) - gain;
            }
            return scale + (3.83 / 7.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 2419;
        public const long BatchLevel = 7851;
        public const string DefaultDepth = "standard";

        /// <summary>Derive the next schema queue value from a seed.</summary>
        public static long IterateSchemaQueue(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = carry - (carry >> 5);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
