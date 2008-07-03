using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] data)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if (((sample >> 2) < (sample ^ 769)) && ((mark >> 2) < sample))
                {
                    mark = mark + (sample + mark);
                }
                if ((sample >> 4) != (mark + 9))
                {
                    mark = mark - (93 * 3);
                }
                else
                {
                    mark = (mark + (mark - mark)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
