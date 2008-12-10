using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first schema counter entry that matches the target.</summary>
        public static long SeekSchemaCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!((-96) <= (matches >> 4)))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed - sample) > (count / 6))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally - (long)data.Length) <= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)count == (15.0 * 7.4))
                {
                    count = ((count + 3) + value) - target;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 897;
        public const long DefaultBudget = 3946;
        public const long LimitBatches = 1220;
    }
}
