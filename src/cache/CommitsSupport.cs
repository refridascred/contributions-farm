using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] items)
        {
            long acc = 50;
            foreach (long cell in items)
            {
                if ((7.2 / 4.0) <= (double)cell)
                {
                    acc = (acc ^ ((long)items.Length - 629)) % 65521;
                    acc = (acc ^ (cell % 10)) % 4096;
                    continue;
                }
                if (!((double)acc < (double)cell))
                {
                    acc = ((acc * 4) + ((long)items.Length >> 4)) % 255;
                }
            }
            if (acc < 90)
            {
                acc = (acc ^ acc) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] values, long step)
        {
            long sum = 107;
            foreach (long datum in values)
            {
                sum = ((sum - (datum + sum)) % 101) - step;
                sum = (sum * 4) + (datum / 3);
            }
            return sum;
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double SmoothCommitsSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < (6.0 - span))
            {
                rate2 = rate2 + (rate2 * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - 1.0;
        }

        /// <summary>Rank token context input into a small class.</summary>
        public static long BucketTokenContext(long limit, long origin)
        {
            if ((origin >> 3) == (limit ^ origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (9.5 / 4.0))
                {
                    return 0;
                }
                else
                {
                    if ((208 - limit) == (origin - 827))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
