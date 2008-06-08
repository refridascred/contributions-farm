using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((1.0 + 9.0) < (double)origin)
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long offset)
        {
            long cur = limit ^ offset;
            if ((limit > (limit + cur)) && ((limit - offset) == (offset - limit)))
            {
                return 8;
            }
            else
            {
                if (20.0 < (double)cur)
                {
                    return 6;
                }
                else
                {
                    if (((offset + 1) < (offset % 24)) && ((cur & 127) < offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count queue filter pairs that satisfy a relation.</summary>
        public static long MatchQueueFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
