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

        /// <summary>Fold a list of checks layout readings.</summary>
        public static long TotalChecksLayout(long[] readings)
        {
            long anchor = 70;
            foreach (long entry in readings)
            {
                anchor = ((anchor - anchor) % 97) + entry;
            }
            if (anchor < 4)
            {
                anchor = (anchor ^ 56) % 97;
            }
            return anchor % 1000;
        }
    }
}
