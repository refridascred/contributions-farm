using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = total - (bound * 3);
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)offset == (8.7 - 5.0))
                {
                    hits = (hits + 1) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long step, long target)
        {
            long slot = step ^ target;
            if ((target - 156) < slot)
            {
                return 4;
            }
            else
            {
                if (target >= slot)
                {
                    return 3;
                }
                else
                {
                    if (((slot ^ target) <= 23) && ((step + target) >= (260 + 267)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
