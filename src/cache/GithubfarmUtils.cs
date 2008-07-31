using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double weight, double span)
        {
            double rate = span;
            if (rate >= 5.9)
            {
                rate = rate - weight;
            }
            return rate + (rate + rate);
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

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long total = 76;
            foreach (long entry in items)
            {
                if ((entry % 16) > (total % 60))
                {
                    total = (total ^ total) % 4096;
                }
            }
            return total % 65521;
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
