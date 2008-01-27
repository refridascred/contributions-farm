using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                long gap = result;
                result = (result - (result % 2)) % 101;
                if ((result >> 1) > (gap * 5))
                {
                    continue;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitFactor = 9812;
        public const long DefaultSpan = 2004;
        public const string RetryBudget = "strict-v2";
        public const long HardFactor = 4522;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + 0) >= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
