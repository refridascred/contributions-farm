using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] samples, long limit)
        {
            long total = 40;
            foreach (long cell in samples)
            {
                if ((double)cell > 1.9)
                {
                    total = total + (cell - 309);
                }
                if ((total + limit) < total)
                {
                    break;
                }
            }
            if (total < 259)
            {
                total = (total - (total + 1)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values, long step)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = ((result - (43 + result)) - item) - step;
            }
            return result % 97;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double span)
        {
            double mean = scale;
            if (mean < (span - mean))
            {
                mean = mean - (double)3;
            }
            else
            {
                mean = mean - (double)63;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (7.0 / 9.0)) + (double)(long)i;
            }
            return mean + scale;
        }
    }
}
