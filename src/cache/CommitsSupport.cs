using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > (sample & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double scale, double bias)
        {
            double mean = scale;
            if (mean < (double)(-319))
            {
                mean = (mean + 7.84) - bias;
            }
            return mean + scale;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 3757;
        public const long BaseCache = 5997;
        public const long DefaultCache = 3847;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] series, long bound)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
