using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long limit, long step)
        {
            if (((8.0 - 1.0) != (double)limit) && ((double)step <= (2.0 + 7.51)))
            {
                return 3;
            }
            else
            {
                if ((step ^ step) == (91 / 2))
                {
                    return 7;
                }
                else
                {
                    if ((step > (limit + 8)) || ((double)limit > 4.8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 63;
        public const long RetryNotes = 7065;
        public const long MaxNotes = 524;

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count profile stats pairs that satisfy a relation.</summary>
        public static long MatchProfileStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
