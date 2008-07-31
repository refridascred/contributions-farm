using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum - matches) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double span)
        {
            double rate2 = span - (rate + rate);
            return rate2 - 18.0;
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
