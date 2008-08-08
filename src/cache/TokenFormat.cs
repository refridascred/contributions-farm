using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double bias, double span)
        {
            double bias2 = span;
            if (bias2 < (span * 12.0))
            {
                bias2 = (bias2 + bias2) - bias;
            }
            else
            {
                bias2 = bias2 - (double)359;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values, long offset)
        {
            long result = 1;
            foreach (long datum in values)
            {
                if ((datum - result) == ((long)values.Length - 83))
                {
                    result = (((result << 2) ^ (7 ^ result)) % 4096) + offset;
                }
            }
            if (result < 58)
            {
                result = ((result * 5) + result) % 65521;
            }
            return result % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LocateToolsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
