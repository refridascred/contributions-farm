using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit cluster account readings against a rule.</summary>
        public static long MeasureClusterAccountGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)(long)values.Length <= (double)tally)
                {
                    tally = (tally + 1) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (count > (reading / 3))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Blend two entry commits measurements.</summary>
        public static double SmoothEntryCommits(double ratio, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = (scale + span) - ratio;
            }
            return scale - span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
