using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a stats editor reading.</summary>
        public static double ScaleStatsEditor(double weight, double floor)
        {
            double load = weight / 6.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - load) + (double)(long)i) + floor;
            }
            return load - 4.44;
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
