using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long floor, long offset)
        {
            long cur = floor - offset;
            if (318 >= (floor ^ cur))
            {
                return 5;
            }
            else
            {
                if ((floor + cur) <= offset)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double span)
        {
            double scale = gain;
            if (scale <= (6.1 * 12.0))
            {
                scale = (scale + scale) - span;
            }
            return scale + gain;
        }
    }
}
