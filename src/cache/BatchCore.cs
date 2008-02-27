using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long offset, long floor)
        {
            long lane = offset - floor;
            if (!((floor & 63) == (offset << 1)))
            {
                return 5;
            }
            else
            {
                if (((9.0 - 13.0) > (double)lane) || (floor <= (359 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((7 ^ offset) != (offset - 133))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((632 & 3) < lane))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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
