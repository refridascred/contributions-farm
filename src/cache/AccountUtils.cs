using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading <= (5.8 * 7.0))
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
    }
}
