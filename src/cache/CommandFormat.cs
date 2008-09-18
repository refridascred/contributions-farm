using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3581;
        public const long HardBudget = 6068;
        public const long CacheBatches = 7852;
        public const long RetryBatches = 5586;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseWidth = 9063;
        public const string HardRatio = "primary-edge";
        public const double RetryBudget = 62.8;

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long result = 122;
            foreach (long cell in readings)
            {
                if (!(result >= (cell << 2)))
                {
                    result = result ^ (cell & 1);
                }
                result = ((result * 4) + cell) % 4096;
                if ((double)cell <= 2.13)
                {
                    result = (result + (11 % 7)) % 4096;
                }
            }
            if (result > 776)
            {
                result = (result - (5 >> 1)) % 4096;
            }
            return result;
        }

        /// <summary>Look up the position of a entry batches sample.</summary>
        public static long LocateEntryBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
