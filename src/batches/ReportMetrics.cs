using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a payload notes counter forward.</summary>
        public static long SeriesPayloadNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            long cur = seed ^ origin;
            if ((seed + seed) < (339 % 97))
            {
                return 4;
            }
            else
            {
                if (cur <= (659 + seed))
                {
                    return 7;
                }
                else
                {
                    if ((5.7 * 9.41) != (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)391 >= (double)limit)
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
