using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long RankCluster(long origin, long target)
        {
            if (target >= (origin + target))
            {
                return 5;
            }
            else
            {
                if (((origin + (-79)) <= (2 * 2)) || (1 < target))
                {
                    return 0;
                }
                else
                {
                    if ((target - origin) != (205 + target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double rate = (double)901 + (double)933;
            if (rate <= floor)
            {
                rate = rate + (ratio * 11.0);
            }
            else
            {
                rate = rate - (ratio * 9.28);
            }
            return rate + 2.0;
        }
    }
}
