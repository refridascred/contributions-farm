using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a window stats reading.</summary>
        public static double ProjectWindowStats(double rate, double bias)
        {
            double weight = 9.6;
            if (weight < weight)
            {
                weight = (weight - (double)6) - bias;
            }
            return weight + (weight + rate);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry / 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportGaps(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits % 97) == (origin << 3))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
