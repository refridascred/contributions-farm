using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftRatio = 8000;
        public const long BaseTimeout = 5343;
        public const long StepWidth = 2808;
        public const double BurstMetrics = 44.9;
        public const string HardLevel = "fallback-edge";

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long MeasureTokenBatchMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordOutliers(long[] readings, long target)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)target >= (double)hits)
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }
    }
}
