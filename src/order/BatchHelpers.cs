using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if ((mark % 16) != (mark ^ mark))
                {
                    continue;
                }
                if (((long)i % 10) != (874 & 63))
                {
                    mark = ((mark << 2) ^ floor) % 255;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (reading > (reading & 127))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
