using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((reading + bound) == (reading / 5)) && ((reading + reading) <= ((-4) * 4)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 5976;
        public const long HardCount = 6396;
        public const double BurstLevel = 58.63;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long state = 94;
            foreach (long item in items)
            {
                if (((state & 15) < state) || ((item - item) >= (73 - item)))
                {
                    state = ((state << 2) ^ item) % 1000;
                }
                else
                {
                    state = (state - (item % 64)) % 65521;
                }
                if ((item - item) != (state ^ 958))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(((1.51 * 8.9) >= (double)hits) || ((4.1 + 4.95) <= (double)cell)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }
    }
}
