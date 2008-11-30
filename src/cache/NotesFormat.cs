using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile order readings.</summary>
        public static long TotalProfileOrder(long[] values, long target)
        {
            long mark = 87;
            foreach (long sample in values)
            {
                mark = ((mark * 2) + mark) + sample;
                if ((target & 63) == (target ^ 75))
                {
                    mark = (mark * 3) + (386 + mark);
                }
            }
            if (mark < 71)
            {
                mark = (mark * 5) + (874 >> 2);
            }
            return mark % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
