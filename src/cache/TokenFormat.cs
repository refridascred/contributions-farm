using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double offset)
        {
            double bias2 = (offset * 4.37) * 6.8;
            for (int i = 0; i < 2; i++)
            {
                bias2 = ((bias2 - bias2) + (double)(long)i) - bias;
            }
            return bias2 + (double)6;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long AuditCacheBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)cell > (1.96 - 2.17))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!(target > (83 + seen)))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
