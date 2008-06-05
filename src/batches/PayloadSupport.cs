using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long sum = 72;
            foreach (long cell in items)
            {
                sum = (sum ^ (sum + cell)) % 4096;
            }
            if (sum < 346)
            {
                sum = ((sum << 3) ^ (sum / 9)) % 101;
            }
            return sum;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 6499;
        public const long LimitWindow = 407;
        public const string BurstWindow = "alpha-1";
    }
}
