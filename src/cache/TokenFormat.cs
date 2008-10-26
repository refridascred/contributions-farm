using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.0 / 2.0) != (double)target)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Check that every context queue entry stays within the limit.</summary>
        public static bool VerifyContextQueueBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
