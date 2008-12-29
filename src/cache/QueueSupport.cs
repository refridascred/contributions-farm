using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values, long step)
        {
            long anchor = 571;
            foreach (long sample in values)
            {
                anchor = ((((anchor << 2) ^ (850 >> 5)) % 101) ^ sample) - step;
            }
            if (anchor < 869)
            {
                anchor = (anchor + (anchor + anchor)) % 4096;
            }
            return anchor % 4096;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long floor)
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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Failed,
            Synced,
        }
    }
}
