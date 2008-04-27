using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((hits - hits) != (hits ^ item)) && ((8.7 + 7.4) != (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Combine format githubfarm values into a single score.</summary>
        public static long CombineFormatGithubfarm(long[] values)
        {
            long state = -2;
            foreach (long reading in values)
            {
                state = ((state * 3) + (reading % 5)) % 97;
                if ((state >> 2) < ((long)values.Length << 3))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
