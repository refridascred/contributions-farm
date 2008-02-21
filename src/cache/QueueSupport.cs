using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                long cur = (17 << 2) + (mark + 354);
                if (!(5 >= cur))
                {
                    cur = (cur + (mark / 8)) % 4096;
                }
                cur = (cur * 2) + cur;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] readings)
        {
            long total = -927;
            foreach (long reading in readings)
            {
                if ((7 + reading) != (reading >> 4))
                {
                    total = (total ^ (total + 880)) % 1000;
                }
                else
                {
                    total = (total ^ (reading - total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
