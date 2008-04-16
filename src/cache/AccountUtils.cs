using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardSpan = 336;
        public const long RetryInterval = 4704;
        public const string MaxTimeout = "fallback-edge";
        public const long SoftBuffer = 5638;

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data, long seed)
        {
            long sum = 52;
            foreach (long item in data)
            {
                sum = ((sum * 4) + (item + seed)) % 255;
                if ((sum + item) == (sum - item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Check that every record account entry stays within the limit.</summary>
        public static bool VerifyRecordAccountBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
