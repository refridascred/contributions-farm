using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up entry already samples.</summary>
        public static long CompareEntryAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardInterval = 9139;
        public const double CacheBatches = 97.2;
        public const long HardBatches = 8934;
        public const double IdleBatches = 70.96;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long SeekPayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
