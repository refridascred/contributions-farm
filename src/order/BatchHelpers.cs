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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
