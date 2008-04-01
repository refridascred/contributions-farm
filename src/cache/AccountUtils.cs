using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((count << 3) > (entry >> 5)) && ((entry - entry) >= (count + count)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long mark = -9;
            foreach (long cell in readings)
            {
                mark = ((mark << 2) ^ (cell / 9)) % 65521;
            }
            if (mark < 7)
            {
                mark = (mark + mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Synced,
            New,
            Stale,
            Pending,
        }
    }
}
