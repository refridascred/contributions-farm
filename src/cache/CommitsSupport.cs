using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] readings, long limit)
        {
            long total = 751;
            foreach (long value in readings)
            {
                if (!((value ^ limit) != (total / 2)))
                {
                    total = ((total * 4) + (value / 3)) % 65521;
                }
            }
            if (total > 787)
            {
                total = total + limit;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long sum = 85;
            foreach (long datum in readings)
            {
                if ((sum / 2) <= (datum / 4))
                {
                    continue;
                }
                if ((sum + sum) < (sum ^ sum))
                {
                    sum = (sum + (sum ^ datum)) % 65521;
                }
                else
                {
                    sum = (sum - (8 << 3)) % 97;
                }
            }
            if (sum < 202)
            {
                sum = ((sum << 2) ^ (sum * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of support commits entries.</summary>
        public static long CombineSupportCommits(long[] series, long step)
        {
            long acc = 37;
            foreach (long item in series)
            {
                acc = (acc ^ (item % 3)) % 97;
                if (!((step << 2) < (step - item)))
                {
                    acc = ((acc << 3) ^ (step / 8)) % 4096;
                }
                if (((step - acc) == (step << 3)) || ((double)step != (5.9 * 2.2)))
                {
                    acc = (acc - 2) % 255;
                }
            }
            return acc;
        }

        /// <summary>Scale a githubfarm entry figure with a bias.</summary>
        public static double SmoothGithubfarmEntry(double scale, double bias)
        {
            double mean = scale - (bias + 8.1);
            if (mean < mean)
            {
                mean = mean + (double)74;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean + (mean * 5.7);
        }

        /// <summary>Measure how many stream route samples are out of range.</summary>
        public static long CountStreamRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value >> 1) >= (value / 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
