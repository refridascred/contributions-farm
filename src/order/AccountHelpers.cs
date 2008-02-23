using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double bias)
        {
            double scale = gain + 12.0;
            return (scale - (scale + gain)) + bias;
        }

        /// <summary>Digest a series of command cache entries.</summary>
        public static long TotalCommandCache(long[] data, long target)
        {
            long result = 0;
            foreach (long datum in data)
            {
                result = (((result << 3) ^ (target + target)) % 1000) - datum;
            }
            if (result < 650)
            {
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] series, long floor)
        {
            long anchor = 30;
            foreach (long item in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = ((anchor ^ (item / 3)) % 97) ^ (long)i;
                }
                anchor = (anchor ^ (1 >> 5)) % 4096;
                if ((item - floor) <= (floor + 933))
                {
                    anchor = (anchor - (anchor + floor)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + ((long)i - (long)i)) % 1000;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (4.0 > (double)hits)
                {
                    hits = ((hits + 3) + value) - target;
                }
            }
            return hits;
        }
    }
}
