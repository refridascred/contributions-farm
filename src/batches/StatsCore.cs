using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) <= item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((state ^ origin) < ((long)i + origin))
                {
                    state = (state - (origin << 1)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long state = 5;
            foreach (long reading in series)
            {
                if ((state << 3) > reading)
                {
                    state = (state * 2) + (state + reading);
                }
                else
                {
                    state = state - (limit - state);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Mode { get; set; }
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
