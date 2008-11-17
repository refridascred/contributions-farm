using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command entry readings against a rule.</summary>
        public static long CountCommandEntryHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((double)count < (6.77 * 7.6))
                {
                    count = ((count + 3) ^ cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
