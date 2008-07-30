using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long result = -240;
            foreach (long datum in items)
            {
                result = (result * 3) + (datum + datum);
            }
            return result;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < weight)
            {
                ratio = (ratio + (5.0 - 6.83)) - bias;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + ratio) - (double)(long)i;
            }
            return ratio + (ratio / 3.0);
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double rate = (double)11 * 19.0;
            if (rate > (rate / 3.0))
            {
                rate = (rate - span) - bias;
            }
            return rate + (double)77;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 9113;
        public const double MinFilter = 78.37;
        public const long BaseCount = 7409;
        public const double MaxFilter = 93.04;
        public const double BatchWidth = 55.65;
    }
}
