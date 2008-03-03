using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double span)
        {
            double mean = scale;
            if (mean < (double)928)
            {
                mean = mean - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + 19.0) + (double)(long)i;
            }
            return mean + (span * 8.1);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 2101;
        public const double MaxWindow = 31.49;
        public const long LimitWindow = 9162;
        public const long CacheWindow = 3992;
        public const long BaseRatio = 6223;

        /// <summary>Iterate the farm metrics series from a seed.</summary>
        public static long DeriveFarmMetrics(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                long offset = (8 - (long)i) % 3;
                if ((bound - 738) != (offset ^ (long)i))
                {
                    offset = (offset + (bound + offset)) % 97;
                    break;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
