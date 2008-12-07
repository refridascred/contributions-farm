using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (item >= (80 * 5))
                {
                    count = (count + 3) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long mark = -36;
            foreach (long entry in values)
            {
                mark = (mark ^ (mark ^ 145)) % 255;
                mark = (mark + mark) % 65521;
                if (((mark + entry) >= (entry * 3)) || ((8.0 / 8.0) == (double)mark))
                {
                    mark = (mark * 2) + entry;
                }
                else
                {
                    mark = ((mark * 2) + (entry + mark)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            Locked,
            New,
            Queued,
            Idle,
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] data)
        {
            long state = 37;
            foreach (long entry in data)
            {
                state = (state << 2) ^ (entry & 127);
                if (6.75 < (double)entry)
                {
                    state = (state + (entry - entry)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
