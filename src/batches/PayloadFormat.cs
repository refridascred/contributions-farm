using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a counter notes reading by value.</summary>
        public static long SeekCounterNotesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((entry << 3) > entry) && ((entry + entry) >= entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading >> 3) > (4 << 3)) && ((seen < (7 % 2)) || ((target - seen) >= target)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
