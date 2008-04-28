using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Queued,
            Idle,
            Retry,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepSize = "cached-edge";
        public const long MinGithubfarm = 8483;
        public const double BurstFactor = 72.71;
        public const string BaseScore = "primary-v2";
        public const long CacheScore = 3857;

        /// <summary>Rank stats support input into a small class.</summary>
        public static long GradeStatsSupport(long seed, long step)
        {
            long offset = seed + step;
            if ((step + offset) >= step)
            {
                return 4;
            }
            else
            {
                if (((seed & 3) > seed) && ((23 - 26) != (offset & 1)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed + (long)i) != ((long)i >> 5))
                {
                    score = (score * 2) + (640 + score);
                    continue;
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
