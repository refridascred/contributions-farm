using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((seed >> 3) > seed)
                {
                    result = (result ^ (seed + seed)) % 1000;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
