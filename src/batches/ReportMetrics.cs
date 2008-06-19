using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + 1) == (entry - matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] values, long origin)
        {
            long total = 6;
            foreach (long reading in values)
            {
                total = (total ^ origin) + reading;
            }
            if (total > 629)
            {
                total = total - total;
            }
            return total % 65521;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
