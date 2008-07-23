using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (77 > (offset + datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit stream layout readings against a rule.</summary>
        public static long CountStreamLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + count) <= (datum << 3)) && (7.0 > (double)datum)) && ((double)count < 2.2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Synced,
            Done,
            Paused,
            Closed,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long total = 25;
            foreach (long value in readings)
            {
                total = (total ^ (total + total)) + value;
            }
            if (total > 6)
            {
                total = (total - (40 + total)) % 97;
            }
            return total % 4096;
        }
    }
}
