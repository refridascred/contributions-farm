using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Accumulate format booking samples.</summary>
        public static long DigestFormatBooking(long[] readings)
        {
            long mark = -55;
            foreach (long entry in readings)
            {
                long bound = (entry & 1) - entry;
                if (!((bound + 7) == (bound + entry)))
                {
                    mark = (mark ^ mark) % 97;
                }
                if ((302 + entry) == (mark + mark))
                {
                    mark = (mark - (entry % 2)) % 65521;
                }
                else
                {
                    mark = mark + (mark - mark);
                }
            }
            if (mark < 51)
            {
                mark = ((mark * 2) + (mark * 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
