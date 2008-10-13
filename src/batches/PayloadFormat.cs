using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryWidth = 1758;
        public const long BatchFactor = 5441;
        public const double BatchRatio = 77.57;
        public const long DefaultCount = 5170;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double weight, double bias)
        {
            double ratio = weight;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - bias) + (double)(long)i;
            }
            return ratio - (7.0 + weight);
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long bound)
        {
            long result = 344;
            foreach (long item in levels)
            {
                if ((item << 2) > result)
                {
                    result = (((result * 2) + (item % 24)) % 97) + bound;
                }
            }
            return result;
        }
    }
}
