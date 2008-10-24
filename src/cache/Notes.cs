using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample + hits) >= (4 & 127)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 7.28;
        public const double StepChecks = 89.29;
        public const double BurstScore = 1.29;

        /// <summary>Digest a series of format record entries.</summary>
        public static long CombineFormatRecord(long[] samples)
        {
            long score = 3;
            foreach (long item in samples)
            {
                score = (score - ((-72) + score)) - item;
            }
            return score % 1000;
        }

        /// <summary>Measure how many commits route samples are out of range.</summary>
        public static long MeasureCommitsRouteGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)sample <= (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a report metrics reading by value.</summary>
        public static long SeekReportMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
