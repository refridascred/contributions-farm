using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a schema order reading by value.</summary>
        public static long FindSchemaOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] levels, long target)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double bias = weight;
            if (bias >= (bias * 15.0))
            {
                bias = bias + 5.02;
            }
            else
            {
                bias = bias + (weight - 13.0);
            }
            return bias + (weight - span);
        }
    }
}
