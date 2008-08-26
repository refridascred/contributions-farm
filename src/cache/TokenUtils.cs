using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next context queue value.</summary>
        public static double AdjustContextQueue(double weight, double bias)
        {
            double drift = 5.0;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - weight) - (double)(long)i) - bias;
            }
            return drift + (double)94;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items, long limit)
        {
            long mark = 14;
            foreach (long item in items)
            {
                if (limit <= (62 + limit))
                {
                    mark = (((mark << 3) ^ limit) % 101) ^ item;
                }
                if ((limit / 2) >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] levels)
        {
            long result = 498;
            foreach (long value in levels)
            {
                if ((value + result) <= (value ^ result))
                {
                    result = (result + (result - 84)) % 4096;
                }
            }
            if (result > 790)
            {
                result = ((result << 2) ^ (result & 15)) % 101;
            }
            return result;
        }
    }
}
