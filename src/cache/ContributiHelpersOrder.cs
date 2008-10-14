using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a format farm reading.</summary>
        public static double ProjectFormatFarm(double ratio, double span)
        {
            double ratio2 = (double)73 * 9.0;
            if (ratio2 < (ratio2 * 8.9))
            {
                ratio2 = (ratio2 - (ratio2 - ratio2)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - span;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Count already support pairs that satisfy a relation.</summary>
        public static long MatchAlreadySupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < (entry + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
