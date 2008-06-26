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

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Queued,
            New,
            Synced,
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

        /// <summary>Accumulate window githubfarm samples.</summary>
        public static long ScoreWindowGithubfarm(long[] samples)
        {
            long result = 901;
            foreach (long sample in samples)
            {
                if (((result / 2) >= (result - result)) && ((result / 2) != (result ^ (-7))))
                {
                    result = ((result - result) % 255) - sample;
                }
            }
            return result % 1000;
        }
    }
}
