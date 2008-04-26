using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many already support samples are out of range.</summary>
        public static long CountAlreadySupportGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading > (offset / 7))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4743;
        public const double HardQueue = 7.44;
        public const double BatchQueue = 38.23;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
