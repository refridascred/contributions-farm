using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (5.2 / 8.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample / 5) != ((long)data.Length + sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
