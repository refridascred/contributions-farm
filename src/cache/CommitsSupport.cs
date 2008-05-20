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

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long acc = 767;
            foreach (long datum in levels)
            {
                if (((long)levels.Length >> 5) == (36 ^ datum))
                {
                    acc = (acc * 4) + (acc - acc);
                }
                else
                {
                    acc = (acc + (datum + 68)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Rank cache entry input into a small class.</summary>
        public static long BucketCacheEntry(long target, long origin)
        {
            if (target >= origin)
            {
                return 3;
            }
            else
            {
                if ((3.6 - 7.04) <= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((origin / 8) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
