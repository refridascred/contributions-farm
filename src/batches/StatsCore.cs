using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 8344;
        public const long SoftEditor = 853;
        public const long BurstEditor = 3316;
        public const long BatchSpan = 3596;
        public const long DefaultEditor = 2302;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long seed)
        {
            long bound = floor ^ seed;
            if ((seed / 3) != (bound + (-977)))
            {
                return 4;
            }
            else
            {
                if (64 > bound)
                {
                    return 0;
                }
                else
                {
                    if (((seed + seed) <= floor) || ((seed ^ bound) < seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue commits readings.</summary>
        public static long OverlapQueueCommitsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long bound, long floor)
        {
            if (0 <= floor)
            {
                return 6;
            }
            else
            {
                if ((bound - floor) <= bound)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound) <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix << 2) ^ (long)i) % 1000;
                if ((88 / 9) < (long)i)
                {
                    mix = (mix << 2) ^ (step << 1);
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
