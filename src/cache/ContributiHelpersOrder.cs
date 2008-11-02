using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] items)
        {
            long mark = 93;
            foreach (long sample in items)
            {
                mark = ((mark - (8 % 16)) % 1000) ^ sample;
            }
            if (mark < 857)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every window counter entry stays within the limit.</summary>
        public static bool CheckWindowCounterBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
