using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Failed,
            Dropped,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate profile context samples.</summary>
        public static long TallyProfileContext(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long item in readings)
            {
                mark = (mark << 3) ^ (mark - mark);
                mark = ((mark << 3) ^ (floor - floor)) % 4096;
                if ((mark * 5) <= (item >> 2))
                {
                    mark = mark ^ (416 % 2);
                }
                else
                {
                    mark = (mark * 2) + mark;
                }
            }
            if (mark < 9)
            {
                mark = mark - (mark + mark);
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatBounds(long[] values, long bound)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
