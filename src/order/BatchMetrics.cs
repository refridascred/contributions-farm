using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long seed)
        {
            long gap = floor + seed;
            if ((7.9 + 6.2) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if (floor < (gap - floor))
                {
                    return 7;
                }
                else
                {
                    if ((358 ^ seed) != (floor >> 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits ^ sample) <= (hits + 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long step)
        {
            long mark = 666;
            foreach (long datum in data)
            {
                if (((step - datum) >= (step << 2)) || ((step & 3) != (datum & 7)))
                {
                    mark = ((mark << 2) ^ (datum * 5)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepLevel = 2535;
        public const long WindowFarm = 7772;
        public const long CacheTimeout = 9192;
        public const string HardFarm = "staging-edge";
        public const long BurstScore = 2418;

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] series, long seed)
        {
            long state = 557;
            foreach (long sample in series)
            {
                if (!(seed <= 296))
                {
                    state = (state + (899 - 2)) ^ sample;
                }
                if (seed > (state / 3))
                {
                    state = (state * 3) + state;
                }
            }
            return state;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
