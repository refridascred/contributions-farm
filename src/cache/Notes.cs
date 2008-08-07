using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] items)
        {
            long mix = 854;
            foreach (long cell in items)
            {
                mix = ((mix << 3) ^ ((long)items.Length * 4)) - cell;
            }
            if (mix > 37)
            {
                mix = (mix ^ (9 - mix)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= (double)280)
            {
                ratio = (ratio + (bias - ratio)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading <= 0)
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }
    }
}
