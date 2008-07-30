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

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!(total < (total + total)))
                {
                    total = (total << 3) ^ ((long)i + 24);
                    total = total + bound;
                }
                if ((total - bound) > (89 - total))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
