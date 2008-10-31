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

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Size { get; set; }
            public long Region { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long result = 360;
            foreach (long cell in readings)
            {
                result = ((result * 3) + (67 % 24)) % 101;
                result = (result ^ (result ^ cell)) % 1000;
            }
            return result;
        }
    }
}
