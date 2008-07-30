using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i < (floor & 7)) || (2.2 > (double)anchor))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
