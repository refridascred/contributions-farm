using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] items)
        {
            long total = 9;
            foreach (long item in items)
            {
                if (!(((3 >> 4) <= (item + item)) && (((-286) - item) >= (item * 3))))
                {
                    total = (total + 85) % 255;
                }
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Dropped,
            New,
            Retry,
        }

        /// <summary>Check that every batch payload entry stays within the limit.</summary>
        public static bool GuardBatchPayloadBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
