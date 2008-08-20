using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (total + total)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((double)count < 10.0) && ((15.0 + 20.0) == (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
