using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double ratio = (double)50 / 6.0;
            if (ratio >= bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (10.0 / 9.0);
            }
            return ratio + weight;
        }

        /// <summary>Measure how many layout token samples are out of range.</summary>
        public static long MeasureLayoutTokenMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (728 < (39 + hits))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchLevel = "strict-1";
        public const string BurstContext = "fallback";
        public const long MaxFactor = 2993;
    }
}
