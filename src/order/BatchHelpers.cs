using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long bound)
        {
            long result = 5;
            foreach (long cell in levels)
            {
                result = (((result << 3) ^ (93 << 3)) ^ cell) + bound;
            }
            if (result > 269)
            {
                result = (result ^ 747) % 4096;
            }
            return result;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double weight = (double)(8 >> 4);
            for (int i = 0; i < 9; i++)
            {
                weight = (((weight - (weight / 8.0)) + (double)(long)i) + ratio) + span;
            }
            return weight - (double)(-9);
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
