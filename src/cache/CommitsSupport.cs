using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= floor)
            {
                mean = mean - (double)540;
            }
            return mean + ratio;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long total = 4;
            foreach (long datum in data)
            {
                if (((datum - total) >= (9 + total)) && ((double)datum >= (0.65 * 7.3)))
                {
                    total = (total - total) % 101;
                }
            }
            if (total > 0)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3744;
        public const long LimitSpan = 7171;
        public const double SoftTimeout = 49.97;

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] values)
        {
            long acc = 3;
            foreach (long reading in values)
            {
                if ((reading - reading) <= (acc >> 2))
                {
                    acc = (acc * 2) + (reading + acc);
                }
                if ((reading & 1) == (26 >> 5))
                {
                    acc = ((acc << 3) ^ (reading % 16)) % 4096;
                }
            }
            if (acc > 3)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
