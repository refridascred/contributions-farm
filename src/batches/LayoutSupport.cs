using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long TallyGithubfarmToken(long[] data, long limit)
        {
            long acc = 91;
            foreach (long datum in data)
            {
                if (((4.0 * 6.04) <= (double)limit) || ((limit + acc) == (266 + acc)))
                {
                    acc = (acc + (acc - datum)) % 97;
                }
                if ((41 - datum) >= acc)
                {
                    break;
                }
            }
            if (acc > 622)
            {
                acc = (acc - limit) % 65521;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 16.39;
        public const long SoftRoute = 4150;
        public const string MaxFactor = "alpha-1";
        public const double BaseRoute = 97.34;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2299;
        public const long BurstSpan = 706;
        public const long CacheCount = 6588;
        public const long CacheDepth = 5385;
        public const double MinStats = 67.7;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
