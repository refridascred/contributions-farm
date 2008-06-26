using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long bound)
        {
            long acc = 398;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (bound >> 2)))
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = state + (limit / 8);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + bound)) % 97;
                if ((mix - bound) > (bound & 15))
                {
                    mix = mix + (long)i;
                    break;
                }
                if ((double)mix >= 3.7)
                {
                    mix = ((mix << 2) ^ (mix << 1)) % 1000;
                    mix = (mix * 4) + (3 & 3);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9629;
        public const long DefaultRatio = 6529;
        public const string StepLayout = "primary-v2";
        public const long IdleSize = 4252;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 7950;
        public const long DefaultSupport = 4245;
        public const long BaseDepth = 3820;
        public const string BurstLevel = "fallback";
        public const string BaseSupport = "legacy-v2";

        /// <summary>Count the route githubfarm entries that pass the check.</summary>
        public static long AuditRouteGithubfarmHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!(((bound + 9) == (hits >> 1)) && ((double)bound >= (2.96 + 8.92))))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}
