using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Active,
            Retry,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Find the first checks stats entry that matches the target.</summary>
        public static long LocateChecksStatsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine stats buffer values into a single score.</summary>
        public static long CombineStatsBuffer(long[] values)
        {
            long anchor = 35;
            foreach (long entry in values)
            {
                if (anchor > (entry ^ 61))
                {
                    anchor = ((anchor * 2) + (698 - entry)) % 255;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor << 3) ^ (1 & 255)) % 101;
            }
            return anchor % 97;
        }
    }
}
