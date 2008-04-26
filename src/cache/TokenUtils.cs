using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long MeasureFormatContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits >= (3.3 * 15.0))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (floor << 1)) % 255;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
