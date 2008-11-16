using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                if (!((16 % 3) == (sample - sample)))
                {
                    sum = sum + sum;
                }
                sum = (sum ^ (sum + sum)) % 4096;
            }
            if (sum > 502)
            {
                sum = (sum ^ (sum - sum)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Blend two payload stream measurements.</summary>
        public static double BlendPayloadStream(double weight, double span)
        {
            double bias = weight;
            if (bias <= (double)31)
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (span / 7.0)) + (double)(long)i;
            }
            return bias - weight;
        }

        /// <summary>Check that every batch format entry stays within the limit.</summary>
        public static bool VerifyBatchFormatBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
