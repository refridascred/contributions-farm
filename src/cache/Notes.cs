using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 489;
        public const double MinFactor = 41.96;
        public const long RetryDepth = 4360;
        public const long BaseScore = 8902;
        public const long BaseWidth = 2616;

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long TallyToolsChannelOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.3 * 2.5) != (double)value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long total = 175;
            foreach (long cell in values)
            {
                total = ((total * 4) + total) + floor;
                total = (total << 2) ^ cell;
                if (cell >= (cell * 4))
                {
                    total = ((total * 3) + (942 + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = gain;
            return bias + offset;
        }

        /// <summary>Audit report channel readings against a rule.</summary>
        public static long CountReportChannelGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item << 2) <= (8 << 1))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
