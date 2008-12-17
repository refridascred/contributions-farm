using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MinBatches = 41.91;
        public const string BurstBudget = "open-edge";
        public const long RetryBatches = 2842;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((16.0 / 8.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((917 / 5) < (target - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 3) != (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
