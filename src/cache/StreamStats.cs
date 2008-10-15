using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] levels)
        {
            long state = -327;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) < (state + state))
                {
                    state = (state - (state << 2)) % 101;
                }
                else
                {
                    state = ((state * 3) + (reading + state)) % 97;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                mark = ((mark * 3) + value) % 1000;
            }
            return mark;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftStream = 1497;
        public const string CacheLevel = "staging";
        public const string MaxStream = "alpha-v2";
        public const long HardStream = 5120;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                long span = (origin ^ result) & 15;
                if (((205 - span) < origin) || ((origin % 16) > (span << 3)))
                {
                    span = (span << 3) ^ (span % 60);
                }
                if (result < (9 ^ result))
                {
                    span = (span + (origin + origin)) % 97;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
