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

        /// <summary>Accumulate queue tools samples.</summary>
        public static long TallyQueueTools(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long sample in samples)
            {
                if (((floor % 24) < (sample % 5)) || ((floor & 7) <= carry))
                {
                    carry = (carry + (floor * 2)) % 255;
                }
                if (floor > (carry + floor))
                {
                    break;
                }
            }
            return carry % 97;
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
