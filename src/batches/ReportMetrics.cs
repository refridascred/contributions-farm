using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                if (((2.68 - 2.1) <= (double)bound) || ((bound * 4) >= bound))
                {
                    result = result - (474 ^ result);
                    result = (result * 4) + (6 - bound);
                }
                else
                {
                    result = (result ^ (result + bound)) % 4096;
                    result = (result << 3) ^ (bound - bound);
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = (((result * 5) + (bound & 1)) % 1000) ^ (long)i2;
                    result = ((result << 2) ^ result) % 255;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 8937;
        public const long SoftInterval = 1683;
        public const double MaxScore = 21.99;
        public const long IdleRatio = 8940;
    }
}
