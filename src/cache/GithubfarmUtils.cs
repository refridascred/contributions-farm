using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < (sample - sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((double)tally <= 9.4)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session order samples.</summary>
        public static long TallySessionOrder(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long cell in readings)
            {
                sum = (((sum << 2) ^ 1) % 97) - cell;
            }
            if (sum > 864)
            {
                sum = sum - (71 - origin);
            }
            return sum;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                double load = (2.2 * 3.7) + 3.1;
                if (load < 6.4)
                {
                    sum = (sum - (bound - (-29))) % 65521;
                }
                else
                {
                    load = load + (double)(long)i;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
