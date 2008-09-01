using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the account buffer entries that pass the check.</summary>
        public static long MeasureAccountBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (datum > ((long)data.Length + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
