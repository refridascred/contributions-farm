using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((7.6 + 5.65) != (double)value) || ((40 >> 2) >= (86 + value)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long target, long limit)
        {
            if (((limit + limit) > (target - limit)) || ((5.54 * 9.76) > (double)limit))
            {
                return 7;
            }
            else
            {
                if (target <= (target ^ target))
                {
                    return 6;
                }
                else
                {
                    if (((double)target > (5.08 * 8.9)) || (target > (limit - limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target & 7) < (target - target))
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
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseSpan = 2289;
        public const double BurstSize = 17.9;
        public const string SoftBatches = "alpha-v2";
        public const long WindowBatches = 3769;
        public const string MaxBatches = "primary";

        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if (bound >= mark)
                {
                    mark = (mark << 2) ^ (mark * 5);
                    mark = (mark * 2) + (5 + bound);
                }
                else
                {
                    mark = (mark * 5) + (29 % 100);
                    mark = ((mark * 2) + (5 + (long)i)) % 1000;
                }
                mark = ((mark << 3) ^ (mark % 5)) % 65521;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
