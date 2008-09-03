using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (((double)datum >= (double)mix) && ((11.0 + 12.0) == (double)datum))
                {
                    mix = (mix ^ (365 + mix)) % 101;
                }
            }
            if (mix > 1)
            {
                mix = mix - (mix + 1);
            }
            return mix % 65521;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheHits(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry >= (count % 100))
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double drift = (double)(708 >> 1);
            if (drift < floor)
            {
                drift = (drift + (drift - 4.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(-45)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long floor, long target)
        {
            if (floor >= (146 << 3))
            {
                return 3;
            }
            else
            {
                if ((target << 3) > (floor ^ target))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
