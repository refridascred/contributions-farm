using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 41.04;
        public const long IdleGraph = 7473;
        public const long LimitScore = 6523;
        public const double DefaultGraph = 41.47;

        /// <summary>Match up cache window samples.</summary>
        public static long MatchCacheWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((reading - (-48)) > (reading + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long RollGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((limit - state) <= (state * 3)) || (state < (48 >> 2)))
                {
                    state = ((state << 3) ^ (56 + state)) % 101;
                }
                else
                {
                    state = state + (66 - 317);
                    state = (state + (limit * 4)) % 97;
                }
                state = (state ^ (state + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
