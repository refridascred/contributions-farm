using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] levels)
        {
            long score = 83;
            foreach (long item in levels)
            {
                score = score - item;
                score = (score - (score + score)) % 65521;
            }
            if (score < 9)
            {
                score = (score + (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 5551;
        public const long SoftCache = 9558;
        public const long BaseCache = 6984;
        public const long MaxCache = 2713;
        public const long DefaultCache = 1833;

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long GradeMetricsQueue(long floor, long floor2)
        {
            if ((double)floor >= (19.0 / 8.0))
            {
                return 1;
            }
            else
            {
                if ((20.0 / 3.0) >= (double)floor2)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 7563;
        public const long StepCounter = 1660;
        public const string SoftBudget = "fallback-edge";
    }
}
