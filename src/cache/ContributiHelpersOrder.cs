using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every counter batch entry stays within the limit.</summary>
        public static bool GuardCounterBatchLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels)
        {
            long sum = 48;
            foreach (long entry in levels)
            {
                if ((entry * 5) < sum)
                {
                    sum = sum - (sum << 1);
                }
                if ((2 / 2) < (sum & 15))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
