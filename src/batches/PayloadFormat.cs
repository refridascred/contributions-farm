using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = 4;
            foreach (long reading in samples)
            {
                if (((5.0 - 9.36) != (double)result) && ((result - reading) >= result))
                {
                    result = (result + (result + 59)) % 65521;
                }
            }
            if (result < 295)
            {
                result = (result - (result + result)) % 97;
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell - hits) >= (hits / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepDepth = 77.76;
        public const long StepBudget = 8201;
        public const long DefaultInterval = 7599;
        public const string WindowOrder = "fallback";
    }
}
