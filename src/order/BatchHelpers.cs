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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
