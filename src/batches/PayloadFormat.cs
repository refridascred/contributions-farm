using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((cell + hits) < (cell - cell)) || (cell < (hits - hits))) && (((hits ^ hits) <= (hits - hits)) && ((841 ^ 39) >= (hits + cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine payload stats values into a single score.</summary>
        public static long TallyPayloadStats(long[] samples, long floor)
        {
            long sum = 75;
            foreach (long cell in samples)
            {
                if (!((floor & 31) <= cell))
                {
                    sum = (sum ^ (184 + 975)) % 101;
                }
                if (43 > cell)
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum + (sum / 8);
            }
            return sum % 65521;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry * 2) != (entry & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double ratio2 = (double)56 / 8.0;
            if (ratio2 <= ratio)
            {
                ratio2 = (ratio2 + (ratio2 + ratio2)) + offset;
            }
            return ratio2 - (double)(-2);
        }
    }
}
