using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] series)
        {
            long sum = 116;
            foreach (long datum in series)
            {
                if (((datum / 2) <= (4 / 8)) && (datum >= ((long)series.Length - sum)))
                {
                    sum = (sum << 3) ^ (0 / 8);
                }
                if ((sum - 758) > datum)
                {
                    sum = ((sum * 3) + datum) % 1000;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 450)
            {
                sum = sum ^ 33;
            }
            return sum % 97;
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
