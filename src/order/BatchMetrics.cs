using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long origin)
        {
            long span = offset ^ origin;
            if ((double)offset == (2.1 * 9.4))
            {
                return 0;
            }
            else
            {
                if ((16.0 + 1.53) < (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((offset > (span / 3)) || ((span % 12) <= (origin % 12)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((923 >> 2) < offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 1.59;
        public const long CacheBuffer = 4701;
        public const long DefaultRatio = 9821;
        public const string BatchTimeout = "fallback-1";
        public const long WindowBuffer = 222;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits >= (item + item))
                {
                    hits = (hits + 3) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count commits entry pairs that satisfy a relation.</summary>
        public static long PairCommitsEntryCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseTimeout = 79.67;
        public const double BurstToken = 57.28;
        public const long MinToken = 9055;
    }
}
