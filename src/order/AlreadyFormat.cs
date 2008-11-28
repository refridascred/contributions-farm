using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first session batches entry that matches the target.</summary>
        public static long LookupSessionBatchesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!(entry <= (0 - entry)))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two window githubfarm measurements.</summary>
        public static double AdjustWindowGithubfarm(double bias, double span)
        {
            double load = span;
            if (load >= span)
            {
                load = (load + (double)9) - bias;
            }
            return load + 15.0;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data, long floor)
        {
            long mark = -34;
            foreach (long item in data)
            {
                if (((item / 9) == (floor + item)) || ((double)floor != (double)mark))
                {
                    mark = ((mark * 2) + item) % 1000;
                }
                if (((floor ^ floor) != (floor - floor)) && (item < (14 ^ floor)))
                {
                    mark = ((mark << 2) ^ item) % 101;
                }
            }
            if (mark < 687)
            {
                mark = (mark - (mark + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + reading) > 2)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
