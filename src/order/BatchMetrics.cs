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

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((long)series.Length / 8) < (hits ^ hits))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + 990) >= (61 >> 4))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }
    }
}
