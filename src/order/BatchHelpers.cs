using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double rate, double offset)
        {
            double weight = rate - offset;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 4.0) + (double)(long)i;
            }
            return weight - 13.0;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series)
        {
            long result = 408;
            foreach (long item in series)
            {
                if (((result & 255) >= 58) || ((item + item) == (result - result)))
                {
                    result = (result ^ item) % 4096;
                }
                if (result <= (item * 5))
                {
                    break;
                }
            }
            if (result > (-88))
            {
                result = (result - (result >> 4)) % 4096;
            }
            return result;
        }

        /// <summary>Compare every pair of stream filter readings.</summary>
        public static long CompareStreamFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
