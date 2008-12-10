using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm layout samples.</summary>
        public static long ScoreFarmLayout(long[] samples, long bound)
        {
            long total = 92;
            foreach (long reading in samples)
            {
                total = (((total << 2) ^ 31) % 97) + bound;
                if (9.2 < (double)reading)
                {
                    total = total - (reading / 7);
                    continue;
                }
                total = (total - (total / 2)) % 255;
                if (total >= (reading + 773))
                {
                    break;
                }
            }
            if (total > 2)
            {
                total = (total * 2) + (total & 31);
            }
            return total % 4096;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((floor << 1) <= floor)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long bound, long origin)
        {
            long gap = bound + origin;
            if (((gap & 7) > origin) && ((bound + gap) > bound))
            {
                return 6;
            }
            else
            {
                if ((91 - origin) <= (gap ^ bound))
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 3) == (648 << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
