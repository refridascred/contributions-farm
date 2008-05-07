using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 72.02;
        public const double IdleRatio = 77.98;
        public const long SoftReport = 5030;
        public const double CacheReport = 72.16;
        public const double BurstReport = 95.51;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepGithubfarm = 7612;
        public const string MinInterval = "stable-1";
        public const double WindowSpan = 22.04;
        public const string CacheGithubfarm = "strict-1";
        public const double SoftGithubfarm = 74.79;

        /// <summary>Combine route stats values into a single score.</summary>
        public static long ScoreRouteStats(long[] readings, long origin)
        {
            long state = -28;
            foreach (long cell in readings)
            {
                if ((cell & 7) != (cell & 1))
                {
                    state = (state + cell) % 101;
                    break;
                }
                state = (state << 3) ^ (state + origin);
                if (((double)state < (11.0 * 2.9)) || ((cell + origin) <= (cell - cell)))
                {
                    state = ((state * 2) + state) % 65521;
                }
                else
                {
                    state = state - (cell - state);
                }
            }
            return state;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
