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

        /// <summary>Fold a list of schema route readings.</summary>
        public static long TotalSchemaRoute(long[] data, long offset)
        {
            long acc = 246;
            foreach (long cell in data)
            {
                acc = ((acc ^ (-78)) % 65521) - cell;
            }
            if (acc < 361)
            {
                acc = (acc + (offset / 5)) % 65521;
            }
            return acc;
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
