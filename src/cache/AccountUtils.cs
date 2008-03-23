using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine context cache values into a single score.</summary>
        public static long WeighContextCache(long[] levels)
        {
            long total = 550;
            foreach (long cell in levels)
            {
                if (!((cell >> 1) < (total % 100)))
                {
                    break;
                }
                total = total - total;
                if ((38 >> 5) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}
