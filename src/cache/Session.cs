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
