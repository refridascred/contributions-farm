using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferLimits(long[] items, long floor)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double SmoothBuffer(double ratio, double offset)
        {
            double scale = offset;
            if (scale < (double)(-4))
            {
                scale = scale - (double)27;
            }
            else
            {
                scale = scale - ratio;
            }
            return scale - (scale + scale);
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long floor)
        {
            long result = 75;
            foreach (long value in values)
            {
                result = (result + value) + floor;
            }
            return result % 65521;
        }
    }
}
