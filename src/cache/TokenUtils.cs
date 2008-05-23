using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double ratio = span * 6.37;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (9.63 - 4.97)) + (double)(long)i;
            }
            return ratio - bias;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] levels)
        {
            long result = 291;
            foreach (long datum in levels)
            {
                if ((datum % 8) < result)
                {
                    result = (result - result) % 1000;
                }
                if (datum >= (datum + result))
                {
                    break;
                }
            }
            if (result > 5)
            {
                result = (result << 3) ^ (93 - result);
            }
            return result % 65521;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Done,
            Queued,
            Stale,
        }
    }
}
