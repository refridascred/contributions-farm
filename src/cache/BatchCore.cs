using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream layout sample.</summary>
        public static long LocateStreamLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long ScoreCounter(long[] values)
        {
            long state = 378;
            foreach (long entry in values)
            {
                state = (state ^ (871 + state)) + entry;
            }
            if (state > 4)
            {
                state = (state ^ (state % 97)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long limit)
        {
            long result = -793;
            foreach (long item in items)
            {
                if (((result - item) <= limit) && ((limit - item) > (item * 4)))
                {
                    result = result - (0 - result);
                }
                if ((limit - item) >= item)
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
