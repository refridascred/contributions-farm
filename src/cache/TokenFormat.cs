using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every checks schema entry stays within the limit.</summary>
        public static bool VerifyChecksSchemaLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a checks session sample.</summary>
        public static long LookupChecksSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double scale = (double)(1 - 741);
            if (scale < (5.0 * 3.9))
            {
                scale = (scale + bias2) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (bias2 * 1.3)) + (double)(long)i;
            }
            return scale + (bias2 / 7.0);
        }
    }
}
