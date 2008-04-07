using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((origin ^ 297) >= (origin + count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
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

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
