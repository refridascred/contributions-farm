using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double bias, double bias2)
        {
            double weight = 6.9;
            if (weight < (bias2 - 8.4))
            {
                weight = weight - (bias / 3.0);
            }
            else
            {
                weight = weight - (10.0 - bias2);
            }
            return weight + bias2;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)value != (double)26)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long TallyCommitsLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry < 8.0)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
