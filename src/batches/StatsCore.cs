using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxBudget = 7008;
        public const long BatchCluster = 2114;
        public const long DefaultCluster = 5937;
        public const string LimitCluster = "standard";

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples)
        {
            long mix = 120;
            foreach (long sample in samples)
            {
                mix = mix + sample;
                if ((double)mix == (0.83 - 18.0))
                {
                    mix = (mix + (mix & 7)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long seed, long origin)
        {
            long prev = seed ^ origin;
            if ((4.9 * 9.7) == (double)prev)
            {
                return 0;
            }
            else
            {
                if (3.0 <= (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many editor githubfarm samples are out of range.</summary>
        public static long AuditEditorGithubfarmHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample <= (sample + sample))
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstScore = 168;
        public const long IdleAlready = 3343;
        public const long MaxAlready = 1907;
        public const string HardSize = "open";
    }
}
