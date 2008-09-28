using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long mark = 752;
            foreach (long reading in readings)
            {
                mark = (mark - (reading / 7)) % 1000;
            }
            if (mark > 6)
            {
                mark = (mark + (mark + 474)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next order metric value from a seed.</summary>
        public static long DeriveOrderMetric(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                if (anchor >= (anchor - anchor))
                {
                    anchor = (anchor - anchor) % 1000;
                    anchor = (anchor << 3) ^ ((long)i / 8);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long origin)
        {
            long acc = 583;
            foreach (long item in readings)
            {
                acc = (acc - (item - item)) % 4096;
                if ((origin + origin) <= (138 & 3))
                {
                    acc = ((acc << 3) ^ (461 ^ acc)) % 101;
                }
            }
            return acc;
        }
    }
}
