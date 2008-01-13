using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (46 > origin)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data)
        {
            long mark = 91;
            foreach (long reading in data)
            {
                if ((double)reading <= 0.5)
                {
                    continue;
                }
                else
                {
                    mark = (mark + mark) % 255;
                }
                mark = ((mark << 3) ^ (mark & 31)) % 1000;
            }
            if (mark < 0)
            {
                mark = mark - (8 - mark);
            }
            return mark % 65521;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Draft,
            Pending,
        }
    }
}
