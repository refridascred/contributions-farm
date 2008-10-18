using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a entry tools reading by value.</summary>
        public static long FindEntryToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long anchor = 595;
            foreach (long cell in values)
            {
                anchor = ((anchor + (6 + anchor)) % 4096) - cell;
            }
            if (anchor < 5)
            {
                anchor = (anchor + (anchor & 15)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (seen >= bound)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
