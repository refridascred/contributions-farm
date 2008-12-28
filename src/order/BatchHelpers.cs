using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((258 + mark) >= 4)
                {
                    mark = ((mark << 3) ^ (mark + offset)) % 1000;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Paused,
            Dropped,
            Idle,
            Stale,
        }
    }
}
