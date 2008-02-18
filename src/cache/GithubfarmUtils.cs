using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long mark = 404;
            foreach (long item in readings)
            {
                mark = (mark * 2) + ((long)readings.Length ^ item);
            }
            return mark;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 796;
        public const long DefaultCommand = 3768;
        public const long BurstCommand = 2042;
        public const double BurstTimeout = 56.5;
    }
}
