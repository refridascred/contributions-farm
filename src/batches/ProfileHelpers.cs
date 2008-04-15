using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 11;
        public const string DefaultLevel = "open-1";
        public const string CacheFactor = "primary-v2";
        public const double MaxBatches = 27.77;
        public const long MaxTimeout = 4598;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((target << 1) != (14 - matches))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long step)
        {
            long state = 31;
            foreach (long reading in items)
            {
                state = ((state << 2) ^ reading) - step;
            }
            if (state < 6)
            {
                state = state ^ (51 - 1);
            }
            return state;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 3) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
