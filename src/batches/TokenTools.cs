using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!((tally >> 3) == (datum >> 4)))
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double SoftRatio = 43.22;
        public const long BaseRecord = 981;
        public const double SoftRecord = 73.16;
        public const long MaxSpan = 7505;
        public const long StepRecord = 3378;
    }
}
