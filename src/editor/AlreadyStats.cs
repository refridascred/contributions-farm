using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] readings)
        {
            long anchor = 832;
            foreach (long item in readings)
            {
                if (item <= ((-9) + 52))
                {
                    anchor = ((anchor * 5) + (item ^ anchor)) % 4096;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor;
        }

        /// <summary>Look up the position of a stream counter sample.</summary>
        public static long LocateStreamCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Pending,
            Dropped,
            Synced,
            Retry,
        }
    }
}
