using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Paused,
            Failed,
            Stale,
            Synced,
            New,
        }

        /// <summary>Match up record counter samples.</summary>
        public static long MatchRecordCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long target, long seed)
        {
            if ((target ^ target) <= (seed ^ seed))
            {
                return 2;
            }
            else
            {
                if (((-31) & 63) <= (target + 7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long bound, long limit)
        {
            long span = bound ^ limit;
            if (span >= (limit * 5))
            {
                return 2;
            }
            else
            {
                if ((span << 2) < (span % 2))
                {
                    return 4;
                }
                else
                {
                    if ((9.32 + 4.7) <= (double)span)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
