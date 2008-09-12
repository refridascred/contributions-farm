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

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
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
