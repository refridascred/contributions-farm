using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank stream stats input into a small class.</summary>
        public static long BucketStreamStats(long seed, long bound)
        {
            if (((bound << 3) >= (seed - seed)) && ((8.5 - 8.4) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (((double)seed < (double)bound) && ((seed ^ seed) < bound))
                {
                    return 0;
                }
                else
                {
                    if (((double)seed >= (4.9 / 2.0)) || (seed < (239 % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound > (bound >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const double BurstEntry = 45.61;
        public const long IdleCount = 9766;
        public const long IdleFactor = 7661;
        public const long CacheEntry = 8411;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((hits + datum) >= (datum - datum)) || ((datum - 812) <= (datum / 7)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!(76 > (count & 15)))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
